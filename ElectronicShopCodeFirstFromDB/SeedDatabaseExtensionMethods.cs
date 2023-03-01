using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ElectronicShopCodeFirstFromDB
{
    public static class SeedDatabaseExtensionMethods
    {
        public static void SeedDatabase(this ElectronicShopEntities context) {
            //context.SeedDatabase();
            context.Database.Log = (s => Debug.Write(s));

			context.Database.Delete();
			context.Database.Create();

			context.SaveChanges();

			// Customer <-> Student
			List<Customer> customers = new List<Customer>() 
            {
                new Customer { Name = "Kara O''Mannion", Phone = "753-739-0862", Address = "17 Pearson Drive", Email = "komannion0@jiathis.com" },
                new Customer { Name = "Lanni MacKessock", Phone = "647-442-1228", Address = "374 Sullivan Alley", Email = "lmackessock1@so-net.ne.jp" },
                new Customer { Name = "Anne-marie Gurnett", Phone = "667-599-7561", Address = "79 Quincy Parkway", Email = "agurnett2@photobucket.com" },
                new Customer { Name = "Jojo Pinckney", Phone = "999-895-5903", Address = "9 Pepper Wood Way", Email = "jpinckney3@cafepress.com" },
                new Customer { Name = "Yasmin Wile", Phone = "258-773-8966", Address = "66632 Arrowood Way", Email = "ywile4@yelp.com" },
                new Customer { Name = "Nicola Mackerel", Phone = "874-233-7813", Address = "68772 Parkside Lane", Email = "nmackerel5@topsy.com" },
                new Customer { Name = "Ofelia Ebbens", Phone = "727-344-9821", Address = "293 Hagan Parkway", Email = "oebbens6@wufoo.com" },
                new Customer { Name = "Lyndsey Hauger", Phone = "976-974-4601", Address = "075 Heffernan Court", Email = "lhauger7@amazon.co.uk" },
                new Customer { Name = "Bendick Petersen", Phone = "351-197-0734", Address = "07 Little Fleur Place", Email = "bpetersen8@washingtonpost.com" },
                new Customer { Name = "Evangelina Sondon", Phone = "311-863-4227", Address = "248 Cody Street", Email = "esondon9@psu.edu" },
                new Customer { Name = "Ado Nattriss", Phone = "430-826-8622", Address = "4312 Buhler Lane", Email = "anattrissa@amazonaws.com" },
                new Customer { Name = "Wolfy Westwell", Phone = "895-812-2017", Address = "0617 Glendale Center", Email = "wwestwellb@nbcnews.com" },
                new Customer { Name = "Agosto Longstreeth", Phone = "845-592-7849", Address = "8529 Troy Center", Email = "alongstreethc@tmall.com" },
                new Customer { Name = "Sigmund Pibworth", Phone = "529-806-4973", Address = "045 Chive Lane", Email = "spibworthd@fda.gov" },
                new Customer { Name = "Stacy Groundwator", Phone = "819-594-5811", Address = "317 Barby Place", Email = "sgroundwatore@zdnet.com" },
                new Customer { Name = "Rab Browne", Phone = "986-127-0556", Address = "27455 Arkansas Terrace", Email = "rbrownef@usda.gov" },
                new Customer { Name = "Faber Laurenz", Phone = "342-276-8753", Address = "89688 Banding Pass", Email = "flaurenzg@symantec.com" },
                new Customer { Name = "Tasia Jepps", Phone = "647-492-3982", Address = "89130 Schmedeman Street", Email = "tjeppsh@howstuffworks.com" },
                new Customer { Name = "Carleen Marjoram", Phone = "132-563-0975", Address = "74 Shelley Pass", Email = "cmarjorami@yale.edu" },
                new Customer { Name = "Niki Stradling", Phone = "892-852-8956", Address = "4 Lighthouse Bay Circle", Email = "nstradlingj@taobao.com" },
            };
            context.Customers.AddRange(customers);
            context.SaveChanges();

            // we have 3 categories, Light, Relay and Energy Meter
            // Department <-> Category
            List<Category> categories = new List<Category>()
            {
                new Category { CategoryCode = "LI", Description = "Light" },
                new Category { CategoryCode = "RE", Description = "Relay" },
                new Category { CategoryCode = "EM", Description = "Energy Meter" },
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();

            // Inventory <-> Course
            List<Inventory> inventories = new List<Inventory>()
            {
                 new Inventory { Name = "12-48V AC - 200mA - ON/OFF Switch", UnitInStock = 100, UnitPrice = 20, CategoryId = 1, Type = "ON/OFF Switch", Current = "200mA", Voltage = "12-48V", Version = "AC" },
                 new Inventory { Name = "110-240V AC - 39mA - ON/OFF Switch", UnitInStock = 100, UnitPrice = 20, CategoryId = 1 ,Type = "ON/OFF Switch", Current = "39mA", Voltage = "110-240V", Version = "AC" },
                 new Inventory { Name = "12-48V AC - 200mA - Movement Detector", UnitInStock = 100, UnitPrice = 30, CategoryId = 1, Type = "Movement Detector", Current = "200mA", Voltage = "12-48V", Version = "AC" },
                 new Inventory { Name = "110-240V AC - 39mA - Movement Detector", UnitInStock = 100, UnitPrice = 30, CategoryId = 1,Type = "Movement Detector", Current = "39mA", Voltage = "110-240V", Version = "AC" },
                 new Inventory { Name = "120V AC - 6A Plug-in", UnitInStock = 100, UnitPrice = 5, CategoryId = 2, Type = "Plug-in", Current = "6A", Voltage = "120V", Version = "AC" },
                 new Inventory { Name = "24V DC - 6A Plug-in", UnitInStock = 100 , UnitPrice = 5, CategoryId = 2, Type = "Plug-in", Current = "6A", Voltage = "24V", Version = "DC"},
                 new Inventory { Name = "120V AC - 6A Faston with Flange Mount", UnitInStock = 100, UnitPrice = 8, CategoryId = 2, Type = "Faston with Flange Mount", Current = "6A", Voltage = "120V", Version = "AC"},
                 new Inventory { Name = "24V DC - 6A Faston with Flange Mount", UnitInStock = 100, UnitPrice = 8, CategoryId = 2, Type = "Faston with Flange Mount", Current = "6A", Voltage = "24V", Version = "DC"},
                 new Inventory { Name = "120V AC - 8A Plug-in", UnitInStock = 100, UnitPrice = 5, CategoryId = 2, Type = "Plug-in", Current = "8A", Voltage = "120V", Version = "AC"},
                 new Inventory { Name = "24V DC - 8A Plug-in", UnitInStock = 100, UnitPrice = 5, CategoryId = 2, Type = "Plug-in", Current = "8A", Voltage = "24V", Version = "DC"},
                 new Inventory { Name = "120V AC - 8A Faston with Flange Mount", UnitInStock = 100, UnitPrice = 8, CategoryId = 2, Type = "Faston with Flange Mount", Current = "8A", Voltage = "120V", Version = "AC"},
                 new Inventory { Name = "24V DC - 8A Faston with Flange Mount", UnitInStock = 100, UnitPrice = 8, CategoryId = 2, Type = "Faston with Flange Mount", Current = "8A", Voltage = "24V", Version = "DC"},
                 new Inventory { Name = "230V AC - 25A Single-Phase", UnitInStock = 100, UnitPrice = 25, CategoryId = 3, Type = "1 Phase", Current = "25A", Voltage = "230V", Version = "AC"},
                 new Inventory { Name = "3x230/400V AC - 65A Three-Phase", UnitInStock = 100, UnitPrice = 45, CategoryId = 3, Type = "3 Phase", Current = "65A", Voltage = "3x230/400V", Version = "AC"},
                 new Inventory { Name = "230V AC - 10A plug-in 5mm pin", UnitInStock = 100, UnitPrice = 4, CategoryId = 2, Type = "Plug-in 5mm pin", Current = "10A", Voltage = "230V", Version = "AC"},
                 new Inventory { Name = "12V DC - 10A plug-in 3.5mm pin", UnitInStock = 100, UnitPrice = 4, CategoryId = 2, Type = "Plug-in 3.5mm pin", Current = "10A", Voltage = "12V", Version = "DC"},
                 new Inventory { Name = "48V DC - 16A PCB 3.5 mm pin flat", UnitInStock = 100, UnitPrice = 4, CategoryId = 2, Type = "PCB 3.5 mm pin flat", Current = "16A", Voltage = "48V", Version = "DC"},
                 new Inventory { Name = "110V AC - 8A plug-in 5mm pin", UnitInStock = 100, UnitPrice = 4, CategoryId = 2, Type = "Plug-in 5mm pin", Current = "8A", Voltage = "110V", Version = "AC"},
                 new Inventory { Name = "24V DC - 16A PCB Mount", UnitInStock = 100, UnitPrice = 10, CategoryId = 2, Type = "PCB Mount", Current = "16A", Voltage = "24V", Version = "DC"},
                 new Inventory { Name = "120V AC - 16A Faston with Flange Mount", UnitInStock = 100, UnitPrice = 10, CategoryId = 2, Type = "Faston with Flange Mount", Current = "16A", Voltage = "120V", Version = "AC"},

            };

            foreach (Inventory inventory in inventories)
            {
                inventory.Category = categories.Find(category => category.CategoryId == inventory.CategoryId);
            }

            context.Inventories.AddRange(inventories);
            context.SaveChanges();

            // Registration <-> Order + OrderDetail
            List<Order> orders = new List<Order>()
            {
                new Order { CustomerId = 10, OrderDate = new DateTime(2018,7,20) },
                new Order { CustomerId = 7, OrderDate = new DateTime(2011,8,31) },
                new Order { CustomerId = 19, OrderDate = new DateTime(2019,8,12) },
                new Order { CustomerId = 20, OrderDate = new DateTime(2017,9,22) },
                new Order { CustomerId = 2, OrderDate = new DateTime(2011,10,07) },
                new Order { CustomerId = 6, OrderDate = new DateTime(2015,5,23) },
                new Order { CustomerId = 10, OrderDate = new DateTime(2013,2,22) },
                new Order { CustomerId = 2, OrderDate = new DateTime(2013,1,25) },
                new Order { CustomerId = 3, OrderDate = new DateTime(2017,5,29) },
                new Order { CustomerId = 12, OrderDate = new DateTime(2018,10,1) },
                new Order { CustomerId = 19, OrderDate = new DateTime(2019,5,20) },
                new Order { CustomerId = 12, OrderDate = new DateTime(2015,12,23) },
                new Order { CustomerId = 13, OrderDate = new DateTime(2017,1,13) },
                new Order { CustomerId = 10, OrderDate = new DateTime(2017,3,30) },
                new Order { CustomerId = 3, OrderDate = new DateTime(2018,7,2) },
                new Order { CustomerId = 9, OrderDate = new DateTime(2021,4,15) },
                new Order { CustomerId = 3, OrderDate = new DateTime(2012,8,14) },
                new Order { CustomerId = 6, OrderDate = new DateTime(2013,5,6) },
                new Order { CustomerId = 9, OrderDate = new DateTime(2013,10,21) },
                new Order { CustomerId = 1, OrderDate = new DateTime(2016,2,10) },

            };

            foreach (Order order in orders)
            {
                order.Customer = customers.Find(customer => customer.CustomerId == order.CustomerId);
            }

            context.Orders.AddRange(orders);
            context.SaveChanges();

            List<OrderDetail> orderDetails = new List<OrderDetail>()
            {
                new OrderDetail { InventoryId = 2, OrderId = 2, OrderQuantity = 5 },
                new OrderDetail { InventoryId = 4, OrderId = 1, OrderQuantity = 10 },
                new OrderDetail { InventoryId = 3, OrderId = 5, OrderQuantity = 15 },
                new OrderDetail { InventoryId = 5, OrderId = 4, OrderQuantity = 20 },
                new OrderDetail { InventoryId = 1, OrderId = 3, OrderQuantity = 25 },
                new OrderDetail { InventoryId = 3, OrderId = 9, OrderQuantity = 25 },
                new OrderDetail { InventoryId = 5, OrderId = 9, OrderQuantity = 90 },
                new OrderDetail { InventoryId = 7, OrderId = 4, OrderQuantity = 30 },
                new OrderDetail { InventoryId = 6, OrderId = 2, OrderQuantity = 10 },
                new OrderDetail { InventoryId = 16, OrderId = 17, OrderQuantity = 80 },
                new OrderDetail { InventoryId = 13, OrderId = 12, OrderQuantity = 50 },
                new OrderDetail { InventoryId = 14, OrderId = 16, OrderQuantity = 5 },
                new OrderDetail { InventoryId = 20, OrderId = 11, OrderQuantity = 70 },
                new OrderDetail { InventoryId = 13, OrderId = 9, OrderQuantity = 55 },
                new OrderDetail { InventoryId = 20, OrderId = 9, OrderQuantity = 100 },
                new OrderDetail { InventoryId = 14, OrderId = 8, OrderQuantity = 5 },
                new OrderDetail { InventoryId = 15, OrderId = 5, OrderQuantity = 15 },
                new OrderDetail { InventoryId = 15, OrderId = 14, OrderQuantity = 10 },
                new OrderDetail { InventoryId = 13, OrderId = 13, OrderQuantity = 75 },
                new OrderDetail { InventoryId = 16, OrderId = 18, OrderQuantity = 50 },

            };


            foreach (OrderDetail orderDetail in orderDetails) 
            {
                orderDetail.Inventory = inventories.Find(inventory => inventory.InventoryId == orderDetail.InventoryId);
                orderDetail.Order = orders.Find(order => order.OrderId == orderDetail.OrderId);
                orderDetail.TotalAmount = orderDetail.OrderQuantity * orderDetail.Inventory.UnitPrice;
            }
            
            context.OrderDetails.AddRange(orderDetails);
            context.SaveChanges();
            

        }

        public static void SaveEntitiesToXMLFiles(this ElectronicShopEntities context)
        {

            context.Configuration.LazyLoadingEnabled = false;
            context.Configuration.ProxyCreationEnabled = false;

            List<Customer> customers = context.Customers.ToList();
            StreamWriter customersFileStream = new StreamWriter("Customers.xml");


            XmlSerializer customerSerializer =
                new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("ListOfCustomers"));
            customerSerializer.Serialize(customersFileStream, customers);

            customersFileStream.Close();



            List<Category> categories = context.Categories.ToList();
            StreamWriter categoriesFileStream = new StreamWriter("Categories.xml");


            XmlSerializer categorySerializer =
                new XmlSerializer(typeof(List<Category>), new XmlRootAttribute("ListOfCategories"));
            categorySerializer.Serialize(categoriesFileStream, categories);

            categoriesFileStream.Close();



            List<Inventory> inventories = context.Inventories.ToList();
            StreamWriter inventoriesFileStream = new StreamWriter("Inventory.xml");


            XmlSerializer inventorySerializer =
                new XmlSerializer(typeof(List<Inventory>), new XmlRootAttribute("ListOfInventory"));
            inventorySerializer.Serialize(inventoriesFileStream, inventories);

            inventoriesFileStream.Close();



            List<Order> orders = context.Orders.ToList();
            StreamWriter ordersFileStream = new StreamWriter("Orders.xml");


            XmlSerializer orderSerializer =
                new XmlSerializer(typeof(List<Order>), new XmlRootAttribute("ListOfOrders"));
            orderSerializer.Serialize(ordersFileStream, orders);

            ordersFileStream.Close();



            List<OrderDetail> orderDetails = context.OrderDetails.ToList();
            StreamWriter fileStream = new StreamWriter("OrderDetails.xml");


            XmlSerializer orderDetailSerializer =
                new XmlSerializer(typeof(List<OrderDetail>), new XmlRootAttribute("ListOfOrderDetails"));
            orderDetailSerializer.Serialize(fileStream, orderDetails);

            fileStream.Close();


        }

        public static void ReadEntitiesFromXMLFiles(this ElectronicShopEntities context) 
        {
            List<Customer> customers;

            StreamReader customersFile = new StreamReader("Customers.xml");

            XmlSerializer customerSerializer =
                new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("ListOfCustomers"));

            customers = customerSerializer.Deserialize(customersFile) as List<Customer>;

            customersFile.Close();

            context.Customers.AddRange(customers);




            List<Category> categories;

            StreamReader categoriesFile = new StreamReader("Categories.xml");

            XmlSerializer categorySerializer =
                new XmlSerializer(typeof(List<Category>), new XmlRootAttribute("ListOfCategories"));

            categories = categorySerializer.Deserialize(categoriesFile) as List<Category>;

            categoriesFile.Close();

            context.Categories.AddRange(categories);




            List<Inventory> inventories;

            StreamReader inventoriesFile = new StreamReader("Inventory.xml");

            XmlSerializer inventorySerializer =
                new XmlSerializer(typeof(List<Inventory>), new XmlRootAttribute("ListOfInventory"));

            inventories = inventorySerializer.Deserialize(inventoriesFile) as List<Inventory>;

            inventoriesFile.Close();

            foreach (Inventory inventory in inventories)
            {
                inventory.Category = context.Categories.ToList().Find(category => category.CategoryId == inventory.CategoryId);
            }

            context.Inventories.AddRange(inventories);





            List<Order> orders;

            StreamReader ordersFile = new StreamReader("Orders.xml");

            XmlSerializer orderSerializer =
                new XmlSerializer(typeof(List<Order>), new XmlRootAttribute("ListOfOrders"));

            orders = orderSerializer.Deserialize(ordersFile) as List<Order>;

            ordersFile.Close();

            foreach (Order order in orders)
            {
                order.Customer = context.Customers.ToList().Find(customer => customer.CustomerId == order.CustomerId);
            }

            context.Orders.AddRange(orders);






            List<OrderDetail> orderDetails;

            StreamReader orderDetailsFile = new StreamReader("OrderDetails.xml");

            XmlSerializer orderDetailSerializer =
                new XmlSerializer(typeof(List<OrderDetail>), new XmlRootAttribute("ListOfOrderDetails"));

            orderDetails = orderDetailSerializer.Deserialize(orderDetailsFile) as List<OrderDetail>;

            orderDetailsFile.Close();

            foreach (OrderDetail orderDetail in orderDetails)
            {
                orderDetail.Inventory = context.Inventories.ToList().Find(inventory => inventory.InventoryId == orderDetail.InventoryId);
                orderDetail.Order = context.Orders.ToList().Find(order => order.OrderId == orderDetail.OrderId);
            }

            context.OrderDetails.AddRange(orderDetails);


            context.SaveChanges();

        }


    }
}
