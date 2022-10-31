
            Console.WriteLine("Welcome To, My First DOB Calc!");

            var Today = DateTime.UtcNow;
            Console.WriteLine("Type in your D.O.B in DD-MM-YYYY format:");

            var MyBirthday = Console.ReadLine();

            var myBirthdayDate = Convert.ToDateTime(MyBirthday);

            var MyAge = Today.Year - myBirthdayDate.Year;

            if (myBirthdayDate.Date > Today.AddYears(-MyAge)) MyAge--;

            Console.WriteLine($"You are {MyAge} years old");
            Console.ReadLine();