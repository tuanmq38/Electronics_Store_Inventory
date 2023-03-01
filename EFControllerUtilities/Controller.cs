using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data.Entity.Infrastructure;

namespace EFControllerUtilities
{
    public static class Controller<C, E> where E : class where C : DbContext, new()
    {
        public static bool DataBaseLogging { get; set; } = true;

        public static C SetContext()
        {
            C context = new C();
            EnableDataBaseLogging(context);
            return context;
        }

        public static void EnableDataBaseLogging(C context)
        {
            if (context == null || DataBaseLogging == false)
            {
                return;
            }
            Debug.WriteLine($"EnableDatabaseLogging() for {context.Database.Connection.Database}");
            context.Database.Log = (s => Debug.Write(s));
            context.SaveChanges();
        }

        public static IEnumerable<E> GetEntities(Func<E, bool> filter = null)
        {
            IEnumerable<E> result;

            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();

                if (filter == null)
                    result = dbSet.ToList();
                else
                {
                    result = dbSet.Where(filter).ToList();
                }
            }

            Debug.WriteLine($"GetEntities<{typeof(E)}>(filter)");
            return result;
        }

        public static List<E> GetEntitiesNoTracking(Func<E, bool> filter = null)
        {
            List<E> result;

            using (var context = SetContext())
            {

                DbSet<E> dbSet = context.Set<E>();

                if (filter == null)
                    result = dbSet.AsNoTracking().ToList();
                else
                {
                    result = dbSet.AsNoTracking().Where(filter).ToList();
                }
            }
            Debug.WriteLine($"GetEntitiesNoTracking<{typeof(E)}>(filter)");
            return result;
        }
        public static List<E> GetEntitiesWithIncluded(params string[] navProperties)
        {
            List<E> result;

            using (var context = SetContext())
            {
                IQueryable<E> query = context.Set<E>();

                foreach (string navProperty in navProperties)
                {
                    query = query.Include(navProperty);
                }

                result = query.ToList<E>();
            }
            Debug.WriteLine($"GetEntitiesWithIncluded<{typeof(E)}>(filter)");
            return result;
        }

        public static bool AnyExists(Func<E, bool> predicate)
        {
            if (predicate == null)
                return false;
            bool result;

            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();
                result = dbSet.Any(predicate);
            }
            Debug.WriteLine($"AnyExists<{typeof(E)}>(predicate)");
            return result;
        }

        public static bool DeleteEntity(params object[] keys)
        {
            bool result = false;
            //using (var context = new C())
            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();
                E entity = dbSet.Find(keys);
                result = DeleteEntity(context, entity);
            }
            Debug.WriteLine($"DeleteEntity<{typeof(E)}>(params keys[])");
            return result;
        }

        public static bool DeleteEntity(E entity)
        {
            bool result = false;
            Debug.WriteLine($"DeleteEntity<{typeof(E)}>({entity})");
            using (var context = SetContext())
            {
                result = DeleteEntity(context, entity);
            }
            return result;
        }

        private static bool DeleteEntity(C context, E entity)
        {
            bool result = false;

            if (entity == null || context == null)
            {
                return result;
            }

            Debug.WriteLine($"\tDeleteEntity<{typeof(E)}>({typeof(C)}, [{entity}])");

            try
            {
                DbEntityEntry<E> entry = context.Entry<E>(entity);
                context.Entry<E>(entity).State = EntityState.Deleted;

                context.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public static bool UpdateEntity(E entity)
        {
            bool result = false;

            if (entity == null)
                return false;

            Debug.WriteLine($"UpdateEntity<{typeof(E)}>({entity})");

            using (var context = SetContext())
            {
                if (context.Entry(entity) == null)
                    return result;

                try
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
                }
            }

            return result;
        }

        public static E FindEntity(params object[] keys)
        {
            E result = null;

            Debug.WriteLine($"FindEntity<{typeof(E)}>(params keys[])");

            if (keys == null || keys.Length == 0)
                return result;

            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();
                result = dbSet.Find(keys); // queries the db
            }

            Debug.WriteLine($"\tFindEntity<{typeof(E)}>(params keys[]) returns {result}");
            return result;
        }

        public static E AddEntity(E entity)
        {
            if (entity == null)
                return null;
            E result = null;

            Debug.WriteLine($"AddEntity<{typeof(E)}>({entity})");

            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();
                result = dbSet.Add(entity);

                try
                {
                    context.SaveChanges();
                    Debug.WriteLine("AddEntity() result: " + result);
                }
                catch (Exception)
                {
                    result = null;
                }
            }

            Debug.WriteLine($"\tAddEntity<{typeof(E)}>({entity}) returns {result}");

            return result;
        }

        public static IEnumerable<E> AddEntities(IEnumerable<E> entities)
        {
            IEnumerable<E> result = null;

            Debug.WriteLine($"AddEntities<{typeof(E)}>(entities)");

            using (var context = SetContext())
            {
                DbSet<E> dbSet = context.Set<E>();
                result = dbSet.AddRange(entities);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    result = null;
                }
            }
            return result;
        }

        static public BindingList<E> SetBindingList(DbSet<E> entities, ListChangedEventHandler eventHandler, Func<E, bool> filter = null)
        {
            BindingList<E> bindingList = SetBindingList(entities, filter);

            Debug.WriteLine($"SetBindingList(<{typeof(E)}>(DbSet, handler, filter)");

            bindingList.ListChanged += eventHandler;

            return bindingList;
        }

        static public BindingList<E> SetBindingList(DbSet<E> entities, Func<E, bool> filter = null)
        {
            entities.Load();
            BindingList<E> bindingList;

            if (filter != null)
            {
                List<E> list = entities.Local.Where(filter).ToList();
                bindingList = new BindingList<E>(list);
            }
            else bindingList = entities.Local.ToBindingList<E>();

            Debug.WriteLine($"SetBindingList(<{typeof(E)}>(DbSet, filter)");

            return bindingList;
        }

        public static BindingList<E> SetBindingList(Func<E, bool> filter = null)
        {

            Debug.WriteLine($"SetBindingList<{typeof(E)}>(filter)");

            return new BindingList<E>(GetEntities(filter) as IList<E>);
        }

        public static ObservableCollection<E> SetObservableCollection(params string[] navProperties)
        {
            Debug.WriteLine($"SetObservableCollection<{typeof(E)}>(navProperties)");

            return new ObservableCollection<E>(GetEntitiesWithIncluded(navProperties));
        }


    }
}
