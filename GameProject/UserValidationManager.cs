using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
