﻿using System;

namespace CSClass31
{
    class Product
    {
        public static int counter = 0;
        public string name = "노네임";
        public int price = 1000 ;
        private int id = -1;

        public Product()
        {
        }

        public Product(string name, int price)
        {
            this.id = counter;
            counter = counter + 1;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return "[" + this.id + "] " + this.name + ": " + this.price;
        }

        ~Product(){
            Console.WriteLine(this.name + "의 소멸자 호출 ㅠㅠ");
        }
    }
}