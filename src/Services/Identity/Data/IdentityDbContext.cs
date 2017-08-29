using BPO.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Identity.Data
{
    public class BPOIdentityDbContext : IdentityDbContext<User,Role,string, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>, IDisposable
    {
        public BPOIdentityDbContext(DbContextOptions<BPOIdentityDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>(b =>
            {
                b.HasKey(u => u.Id);
                b.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
                b.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");
                b.ToTable("sys_User");
                b.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
                b.Property(u => u.UserName).HasColumnType("varchar(256)");
                b.Property(u => u.NormalizedUserName).HasColumnType("varchar(256)");
                b.Property(u => u.Email).HasColumnType("varchar(256)");
                b.Property(u => u.NormalizedEmail).HasColumnType("varchar(256)");

                // Replace with b.HasMany<IdentityUserClaim>().
                b.HasMany<UserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();
                b.HasMany<UserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();
                b.HasMany<UserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();
            });

            builder.Entity<UserClaim>(b =>
            {
                b.HasKey(uc => uc.Id);
                b.ToTable("sys_UserClaim");
            });

            builder.Entity<UserLogin>(b =>
            {
                b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
                b.ToTable("sys_UserLogin");
            });

            builder.Entity<UserToken>(b =>
            {
                b.HasKey(l => new { l.UserId, l.LoginProvider, l.Name });
                b.ToTable("sys_UserToken");
            });

            builder.Entity<User>(b =>
            {
                b.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            });

            builder.Entity<Role>(b =>
            {
                b.HasKey(r => r.Id);
                b.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();
                b.ToTable("sys_Role");
                b.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

                b.Property(u => u.Name).HasColumnType("varchar(256)");
                b.Property(u => u.NormalizedName).HasColumnType("varchar(256)");

                b.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();
                b.HasMany<RoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();
            });

            builder.Entity<RoleClaim>(b =>
            {
                b.HasKey(rc => rc.Id);
                b.ToTable("sys_RoleClaim");
            });

            builder.Entity<UserRole>(b =>
            {
                b.HasKey(r => new { r.UserId, r.RoleId });
                b.ToTable("sys_UserRole");
            });
        }
 

        //public T Update<T>(T entity) where T : class
        //{
        //    var set = this.Set<T>();
        //    set.Attach(entity);
        //    this.Entry<T>(entity).State = EntityState.Modified;
        //    return entity;
        //}

        public T Insert<T>(T entity) where T : class
        {
            this.Set<T>().Add(entity);
            return entity;
        }

        public void Delete<T>(T entity) where T : class
        {
            this.Entry<T>(entity).State = EntityState.Deleted;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete<T>(Expression<Func<T, bool>> conditions) where T : class
        {
            var queryList = conditions == null ? this.Set<T>() : this.Set<T>().Where(conditions) as IQueryable<T>;
            this.Set<T>().RemoveRange(queryList);

            return true;
        }
        //public T Find<T>(params object[] keyValues) where T : class
        //{
        //    return this.Set<T>().Find(keyValues);
        //}
        public virtual Task<T> GetByIdAsync<T>(object id) where T : class
        {
            return this.Set<T>().FindAsync(new object[] { id });
        }
        public virtual Task<bool> AnyAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return this.Set<T>().AnyAsync(predicate);
        }
        public IQueryable<T> FindAll<T>(Expression<Func<T, bool>> conditions = null) where T : class
        {
            if (conditions == null)
                return this.Set<T>().AsQueryable<T>();
            else
                return this.Set<T>().Where(conditions).AsQueryable<T>();
        }
    }
}
