using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class Car
    {
       private string model;
       public string Brand="";
       public double Price;
        public string Model
        {
            //get { return model; }
            set {
                if (value.Length > 4)
                {
                    model = value;
                }
                if (value != "2013")
                {
                    model = value;
                }
                else
                {
                    Console.WriteLine("Model Can not be 2013");
                }
            }
        }


        public int Prices { get; set; } = 100;
        //public void SetModel(string model)
        //{
        //    if(model.Length>4)
        //    {
        //        Model = model;
        //    }
        //    if (model != "2013")
        //    {
        //        Model = model;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Model Can not be 2013");
        //    }
        //}
        //public string GetModel()
        //{
        //    return Model;
        //}
    }
    internal class Suzuki:Car
    {
        public static void Main()
        {
            Suzuki obj = new Suzuki();
            obj.Brand = "Swift";
            obj.Price = 2000000;
            obj.Model = "2013RC";

            Console.WriteLine($"Brand={obj.Brand} Model= Price={obj.Price}");
        
        }

    }
    class Honda:Car
    {
        double DisountPrice;
        public double CalculateDiscountPrice(double Price )
        {
            return Price * 0.01;
        }
        //public static void Main()
        //{
        //    Honda obj = new Honda();
        //    obj.Brand = "Brand";
        //    obj.Model = "Model";
        //    obj.Price = 10000000;
        //    obj.DisountPrice = obj.CalculateDiscountPrice(obj.Price);
        //    Console.WriteLine($"Brand={obj.Brand} Model={ obj.Model} Price={obj.Price} Discount Price={obj.DisountPrice}");


        //}

    }

}
