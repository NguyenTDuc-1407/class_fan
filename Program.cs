            //Đối tượng Fan 1: Gán giá trị lớn nhất cho speed, radius là 10,
            //color là yellow và quạt ở trạng thái bật.
            Setting_Fan fan1 = new Setting_Fan(Setting_Fan.FAST, true, 10, "yellow");
            //Đối tượng Fan 2: Gán giá trị trung bình cho speed, radius là 5,
            //color là blue và quạt ở trạng thái tắt
            Setting_Fan fan2 = new Setting_Fan(Setting_Fan.MEDIUM, true, 5, "blue");
            Console.WriteLine(fan2.ToString());