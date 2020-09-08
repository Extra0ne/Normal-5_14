using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normal_5_14
{
  public class Person
    {
        private string name;
        private int experience;
        private int salary;
        private int worked_hourse;
        double premium;

        public void input()
        {
            Console.Write("Введите имя работника: ");
            name = Convert.ToString(Console.ReadLine());

            Console.Write("Введите стаж работника: ");
            experience = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите зарплату за час: ");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите кол-во отработанных часов: ");
            worked_hourse = Convert.ToInt32(Console.ReadLine());
        }

        public void output()

        {
            if (experience <1 ^ salary <1 ^ worked_hourse <1 )
            {
                Console.WriteLine("Вы ввели отрицательное число");
                
            }
            else
            {
                if (experience < 1)
                {
                    premium = 0.0;
                }
                else
                {
                    if (experience >= 1 && experience < 3)
                    {
                        premium = 0.05 * (salary * worked_hourse);
                    }
                    else
                    {
                        if (experience >= 3 && experience < 5)
                        {
                            premium = 0.08 * (salary * worked_hourse);
                        }
                        else
                        {
                            if (experience >= 5)
                            {
                                premium = 0.15 * (salary * worked_hourse);
                            }
                        }
                    }
                    
                }
                Console.WriteLine("\nИмя работника {0}", name);
                Console.WriteLine("Стаж работы: {0}", experience);
                Console.WriteLine("З/П в час: {0}", salary);
                Console.WriteLine("Отработанно часов: {0}", worked_hourse);
                Console.WriteLine("Зарплата: {0}", salary * worked_hourse);
                Console.WriteLine("Премия: {0}", premium);
            }

            

            
        }
    }
}
