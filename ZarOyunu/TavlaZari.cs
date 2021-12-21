using System;
using System.Collections.Generic;
using System.Text;

namespace ZarOyunu
{
    class TavlaZari
    {
        /// <summary>
        /// Zarın alabileceği maksimum değer değişkeni
        /// </summary>
        int maksimumZarDegeri;

        Random random = new Random();

        /// <summary>
        /// Zarın labileceği maksimum değeri giriniz
        /// </summary>
        /// <param name="maksimumZarDegeri"></param>

        public TavlaZari(int maksimumZarDegeri)
        {
          this.maksimumZarDegeri = maksimumZarDegeri;
        }
        
        /// <summary>
        /// Rastgele bir sayı için zar at
        /// </summary>
        /// <returns></returns>

        public int ZarAt()
        {
            //Rastgele sayı üretilecek
            return random.Next(1, maksimumZarDegeri + 1);

        }      
    }
}
