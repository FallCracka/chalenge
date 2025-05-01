                
using System;

namespace Novel 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Сделано Лидией");
            Console.WriteLine("Нажмите чтобы продолжить...");
            Console.ReadKey();
            StartNovel();
        }

        static void StartNovel()
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в консольную новелу!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Game();
        }

        static void Game()
        {
            try
            {
                Console.WriteLine("Вы проснулись в таинственном лесу.");
                Console.WriteLine("Оглядевшись, вы поняли, что оказались в волшебном месте, полном загадок.");
                Console.WriteLine("Перед вами пять тропинок...");

                Console.WriteLine("\nКакую тропинку выберете?");
                Console.WriteLine("1. Пойдёте к светящемуся дереву.");
                Console.WriteLine("2. Решите, что это просто сон, и останетесь на месте.");
                Console.WriteLine("3. Позовёте на помощь друга, чтобы вместе исследовать лес.");
                Console.WriteLine("4. Решите вернуться домой и рассказать о своих приключениях.");
                Console.WriteLine("5. Попробуете собрать странные цветы, растущие вокруг.");

                int choice1 = Convert.ToInt32(Console.ReadLine());

                if (choice1 == 1)
                {
                    Console.WriteLine("\nВы подошли к светящемуся дереву. Оно оказалось волшебным!");
                    Console.WriteLine("Дерево заговорило с вами: 'Спасибо, что пришли! Я дам вам одну подсказку о древнем артефакте.'");

                    Console.WriteLine("\nЧто вы спросите у дерева?");
                    Console.WriteLine("1. Где найти артефакт?");
                    Console.WriteLine("2. Как использовать артефакт?");
                    Console.WriteLine("3. Как защититься от опасностей леса?");
                    Console.WriteLine("4. Как вернуться домой?");
                    Console.WriteLine("5. Как помочь другим путешественникам?");

                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 == 1)
                    {
                        Console.WriteLine("\nДерево указало на гору вдали: 'Там ты найдёшь то, что ищешь.'");
                        Console.WriteLine("Вы отправились в путь и нашли артефакт, который изменил вашу жизнь.");
                        Varible.end = "Концовка: Путь к открытию.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice2 == 2)
                    {
                        Console.WriteLine("\nДерево ответило: 'Используй его с добрыми намерениями, и он принесёт тебе удачу.'");
                        Console.WriteLine("Вы вернулись домой и использовали артефакт, чтобы помочь другим.");
                        Varible.end = "Концовка: Сила доброты.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice2 == 3)
                    {
                        Console.WriteLine("\nДерево шепнуло: 'Слушай природу, и она защитит тебя.'");
                        Console.WriteLine("Вы научились понимать язык леса и стали его защитником.");
                        Varible.end = "Концовка: Защитник леса.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice2 == 4)
                    {
                        Console.WriteLine("\nДерево улыбнулось: 'Следуй за светом, и ты найдёшь путь домой.'");
                        Console.WriteLine("Вы нашли дорогу и вернулись, полные новых впечатлений.");
                        Varible.end = "Концовка: Путь домой.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice2 == 5)
                    {
                        Console.WriteLine("\nДерево ответило: 'Помогай тем, кто потерялся, и они помогут тебе.'");
                        Console.WriteLine("Вы стали проводником для других и нашли много друзей.");
                                                Varible.end = "Концовка: Друзья навсегда.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                }
                else if (choice1 == 2)
                {
                    Console.WriteLine("\nВы остались на месте, размышляя о том, что это всего лишь сон.");
                    Console.WriteLine("Но вскоре вы поняли, что лес полон чудес, и ваше сердце наполнилось спокойствием.");
                    Varible.end = "Концовка: Спокойствие в мечтах.";
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Final();
                }
                else if (choice1 == 3)
                {
                    Console.WriteLine("\nВы позвали своего друга, чтобы он помог вам исследовать лес.");
                    Console.WriteLine("Вместе вы нашли старую карту, которая указывала на местоположение артефакта.");
                    Console.WriteLine("\nЧто вы сделаете дальше?");
                    Console.WriteLine("1. Отправитесь на поиски артефакта.");
                    Console.WriteLine("2. Решите, что карта может быть подделкой, и вернётесь домой.");
                    Console.WriteLine("3. Попросите помощи у местных жителей.");
                    Console.WriteLine("4. Спрячете карту и вернётесь за ней позже.");
                    Console.WriteLine("5. Попробуете сжечь карту, чтобы не привлекать внимание.");

                    int choice3 = Convert.ToInt32(Console.ReadLine());

                    if (choice3 == 1)
                    {
                        Console.WriteLine("\nВы и ваш друг отправились на поиски артефакта.");
                        Console.WriteLine("После долгих приключений вы нашли его и стали героями своего города.");
                        Varible.end = "Концовка: Герои приключений.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("\nВы решили, что карта может быть подделкой, и вернулись домой.");
                        Console.WriteLine("Но вскоре узнали, что артефакт был настоящим, и вы упустили шанс.");
                        Varible.end = "Концовка: Упущенная возможность.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice3 == 3)
                    {
                        Console.WriteLine("\nВы обратились за помощью к местным жителям.");
                        Console.WriteLine("Они рассказали вам о древних легендах и помогли найти артефакт.");
                        Varible.end = "Концовка: Сила сообщества.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice3 == 4)
                    {
                        Console.WriteLine("\nВы спрятали карту и решили вернуться за ней позже.");
                        Console.WriteLine("Но на следующий день вы не смогли найти её, и тайна осталась неразгаданной.");
                        Varible.end = "Концовка: Тайна потерянной карты.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice3 == 5)
                    {
                        Console.WriteLine("\nВы сожгли карту, чтобы не привлекать внимание.");
                        Console.WriteLine("Но вскоре поняли, что это была единственная подсказка к артефакту.");
                        Varible.end = "Концовка: Печаль утраты.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                }
                else if (choice1 == 4)
                {
                    Console.WriteLine("\nВы решили вернуться домой и рассказать о своих приключениях.");
                    Console.WriteLine("Ваши родители были рады вас видеть и слушали ваши истории с интересом.");
                    Console.WriteLine("Вы поняли, что иногда лучше делиться своими переживаниями с близкими.");
                    Varible.end = "Концовка: Семейные узы.";
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Final();
                }
                else if (choice1 == 5)
                {
                    Console.WriteLine("\nВы начали собирать странные цветы, растущие вокруг.");
                    Console.WriteLine("Вдруг один из цветов заговорил: 'Спасибо, что меня собрали! Я дам вам одно желание.'");

                    Console.WriteLine("\nЧто вы пожелаете?");
                                        Console.WriteLine("1. Чтобы все ваши мечты сбылись.");
                    Console.WriteLine("2. Чтобы вы могли понимать язык животных.");
                    Console.WriteLine("3. Чтобы у вас была сила защищать лес.");
                    Console.WriteLine("4. Чтобы вы всегда находили путь домой.");
                    Console.WriteLine("5. Чтобы вы могли путешествовать по другим мирам.");

                    int choice5 = Convert.ToInt32(Console.ReadLine());

                    if (choice5 == 1)
                    {
                        Console.WriteLine("\nЦветок улыбнулся: 'Твои мечты сбудутся, но помни, что счастье — в простых вещах.'");
                        Console.WriteLine("Вы вернулись домой, и с тех пор ваша жизнь наполнилась радостью и чудесами.");
                        Varible.end = "Концовка: Мечты сбываются.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice5 == 2)
                    {
                        Console.WriteLine("\nЦветок кивнул: 'Теперь ты сможешь понимать язык животных. Используй этот дар с умом.'");
                        Console.WriteLine("Вы вернулись домой и начали общаться с животными, которые стали вашими друзьями.");
                        Varible.end = "Концовка: Дар общения с природой.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice5 == 3)
                    {
                        Console.WriteLine("\nЦветок сказал: 'Теперь ты сможешь защищать лес от опасностей.'");
                        Console.WriteLine("Вы стали защитником леса и помогали всем, кто нуждался в помощи.");
                        Varible.end = "Концовка: Защитник природы.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice5 == 4)
                    {
                        Console.WriteLine("\nЦветок ответил: 'Следуй за светом, и ты всегда найдёшь путь домой.'");
                        Console.WriteLine("Вы нашли дорогу и вернулись, полные новых впечатлений и историй.");
                        Varible.end = "Концовка: Путь домой.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice5 == 5)
                    {
                        Console.WriteLine("\nЦветок сказал: 'Ты можешь путешествовать по другим мирам, но помни о своих корнях.'");
                        Console.WriteLine("Вы отправились в удивительные приключения, исследуя новые миры и культуры.");
                        Varible.end = "Концовка: Путешественник по мирам.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                }
                else
                {
                    Console.WriteLine("\nВы так и не решились сделать выбор. Лес остался полон тайн.");
                    Varible.end = "Концовка: Неопределенность.";
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Final();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Restart();
            }
        }

        static void Final()
        {
            Console.Clear();
            Console.WriteLine(Varible.end);
            Console.WriteLine("\nВведите 1, чтобы продолжить игру:");
            try
            {
                int choice1 = Convert.ToInt32(Console.ReadLine());
                if (choice1 == 1)
                {
                    Restart();
                }
                else
                {
                    Console.WriteLine("\nСпасибо за игру! Будем с нетерпением ждать вас снова!");
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Спасибо за игру! Будем с нетерпением ждать вас снова!");
            }
        }

        static void Restart()
        {
            StartNovel();
        }
    }

    class Varible
    {
        public static String end;
    }
}
