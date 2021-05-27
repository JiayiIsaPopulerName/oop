using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace oop
{       

    public abstract class Animal
    {    
    }
     class young : Animal
    {
        public int Ny;
        public int NyO;
        

        public int numberNy
        {
            get { return Ny;}
            set { Ny = value; }
        }

        public int Add(float x)
        {
           NyO = (int)(1 + x) * Ny;
            return 0;
        }
        public int dead(float x)
        {
            Ny = (int) x * Ny;
            return 0;
        }
        int R = 20;//
    }
    class adult : Animal
    {
        public int Na;

        public int numberNy//年轻动物数量
        {
            get { return Na; }
            set { Na = value; }
        }

        public int Add(float x)
        {
            Na = (int)(1 + x) * Na;
            return 0;
        }
        public int dead(float x)
        {
            Na = (int)(1 - x) * Na;
            return 0;
        }

    }
    class old : Animal
    {
        public int No;

        public int numberNy
        {
            get { return No; }
            set { No = value; }
        }

        public int Add(float x)
        {
            No = (int)(1 + x) * No;
            return 0;
        }
        public int dead(float x)
        {
            No = (int)(1 - x) * No;
            return 0;
        }

    }


    public class Building
    {
    }

    public class AnimalCollection : IEnumerable<Animal>
    {
        private readonly IList<Animal> animals = new List<Animal>();

        public void Add(Animal animal)
        {
            animals.Add(animal);
        }

        public void Remove(Animal animal)
        {
            animals.Remove(animal);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return animals.GetEnumerator();
        }
    }
}
