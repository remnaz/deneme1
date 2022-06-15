﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{

    class GamerManager : IGamerService
    {
        //generate constructer
        IUserValidation _userValidation;

        public GamerManager()
        {
        }

        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }



        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt olunamadı.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }
    }
}
