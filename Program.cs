﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class QuestionNode
{
    public string Question { get; set; }
    public List<string> Tags { get; set; } = new List<string>();
    public QuestionNode YesBranch { get; set; }
    public QuestionNode NoBranch { get; set; }
}
class Cake
{
    public int Id { get; set; }
    public List<string> Tags { get; set; }
    public string Photo { get; set; }
}

class Program
{
    static void Main()
    {
        string jsonPath = "data.json";
        var cakes = JsonConvert.DeserializeObject<List<Cake>>(File.ReadAllText(jsonPath));


        //var questions = new Dictionary<string, string>
        //{
        //{"Вам нравятся квадратные торты?", "square_shape"},
        //  {"Предпочитаете классическую круглую форму?", "round_shape"},

        //    {"Торт для дня рождения?", "birthday"},
        //    {"Этот торт для свадьбы или годовщины?", "wedding"},
        //    {"Вы хотите одноярусный торт?", "single_tier"},
        //    {"Вам по душе минималистичный стиль?", "minimalism"},
        //   {"Хотите, чтобы декор был насыщенным и детализированным?", "detailed_decor"},
        //    {"Нравятся яркие, сочные цвета в оформлении?", "bright_colors"},
        //    {"Вам ближе нежные пастельные оттенки?", "pastel_colors"},
        //    {"Предпочитаете глубокие, тёмные тона?", "dark_colors"},
        //    {"Хотите украсить торт топпером сверху?", "topper_on_top"},
        //    {"Предпочитаете топпер, закреплённый сбоку?", "topper_on_side"},
        //    {"Топпер — обязательный элемент для вашего торта?", "topper"},
        //          {"Надпись на торте — важный элемент?", "inscription_on_cake"},
        //         {"Этот торт для ребёнка?", "child"},
        //   {"Хотите торт в стиле ламбет (объемный, с рюшами и узорами)?", "lambert"},
        //       {"Предпочитаете однотонное оформление торта?", "solid_color"},
        //    {"Хотите торт с бархатным (велюровым) покрытием?", "velvet"},
        //    {"Нравится, когда торт расписан узорами или рисунками?", "detailed_decor"},
        //    {"Торт для рыбака?", "fisherman"},
        //    {"Торт для мужчины?", "man"},
        //    {"Торт для охотника?", "hunter"},
        //    {"Торт для футбольного фаната?", "football_fan"},
        //    {"Торт для женщины?", "woman"},
        //    {"Хотите, чтобы торт был белым?", "white"},
        //    {"Предпочитаете чёрный торт?", "black"},
        // {"Хотели бы разместить фотографию виновника торжества на торте?", "photo_on_cake"},
        //    {"Нравятся торты с тайным посланием (сжигается верхний слой)?", "secret_message"},
        //    {"Это гендерный торт?", "gender_reveal"},
        //    {"Это торт для предложения?", "proposal"},
        //    {"Это торт для сообщения какой-то новости?", "news_announcement"},
        //    {"Предпочли бы высокий вытянутый торт?", "tall"},
        //    {"Вам нравятся торты необычной формы (например, сердце, цифра, геометрия)?", "unique_shape"},
        //   {"Хотите торт в стиле 'голый торт' (naked cake) с минимальным покрытием?", "naked"},
        //    {"Нравятся зеркальные (глянцевые) глазури?", "mirror_glaze"},
        //    {"Хотите, чтобы торт был украшен мраморным эффеком?", "marble_effect"},
        //          {"Хотите, чтобы торт выглядел 'дорого' и роскошно?", "luxurious"},
        //    {"Хотите, чтобы торт был с эффектом омбре (плавный переход цвета)?", "ombre"},
        //   {"В вашем торте может быть фальш-ярус?", "fake_tier"},
        //           {"Торт должен соответствовать конкретной тематике?", "themed_cake"},
        //    {"Торт должен быть вдохновлён природой (горный, лесной, морской стиль)?", "nature_cake"},
        //    {"Торт должен быть шуточный?", "funny_cake"},
        //    {"Хотите торт, вдохновлённый вашим любимым фильмом, сериалом или мультфильмом?", "movie_inspired"},
        //    {"Нравятся торты в стиле известных брендов (например, Chanel, Louis Vuitton, Gucci)?", "brand_style"}
        
        ////Вопросы ниже не струтурированы ещё

        //  //    {"Хотите, чтобы торт был украшен карамельными элементами?", "caramel_decor"},
        ////    {"Хотите, чтобы торт был украшен шоколадным декором?", "chocolate_decor"},
        ////    {"Нравятся торты с металлическим декором (золотые, серебряные элементы)?", "metallic_decor"},
        //     //    {"В вашем торте есть светящиеся элементы (огоньки, светящийся ярус)?", "glowing_cake"},
        ////    {"В вашем торте используется декор 'жемчужные бусы'?", "pearl_beads"},
        // //    {"Хотите добавить блестки, создающие эффект сияния?", "glitter"},
        ////    {"Украшение свежими ягодами — ваш выбор?", "fresh_berries"},
        //     //    {"Хотите добавить блестки, создающие эффект сияния?", "glitter"},
        ////    {"Украшение свежими ягодами — ваш выбор?", "fresh_berries"},
        //   //    {"Нравятся шоколадные подтеки на торте?", "chocolate_drips"},
        ////    {"Хотите фигурку сверху в качестве декора?", "cake_figurine"},
        //  //    {"Хотите украсить торт живыми цветами?", "fresh_flowers"},
        ////    {"Предпочитаете съедобные цветы в декоре?", "edible_flowers"},
        //};

        var firstRoot = new QuestionNode//форма
        {

            Question = "Предпочитаете классическую круглую форму?",
            Tags = new List<string> { "round_shape" },
            YesBranch = new QuestionNode
            {
                Question = "Предпочли бы высокий вытянутый торт?",
                Tags = new List<string> { "tall" },
                YesBranch = new QuestionNode
                {
                    Question = "Вы хотите одноярусный торт?",
                    Tags = new List<string> { "single_tier" },
                    NoBranch = new QuestionNode
                    {
                        Question = "В вашем торте может быть фальш-ярус??",
                        Tags = new List<string> { "fake_tier" },
                    }
                },

            },
            NoBranch = new QuestionNode
            {
                Question = "Вам нравятся квадратные торты?",
                Tags = new List<string> { "square_shape" },
                YesBranch = new QuestionNode
                {
                    Question = "Предпочли бы высокий вытянутый торт?",
                    Tags = new List<string> { "tall" },
                    YesBranch = new QuestionNode
                    {
                        Question = "Вы хотите одноярусный торт?",
                        Tags = new List<string> { "single_tier" },
                        NoBranch = new QuestionNode
                        {
                            Question = "В вашем торте может быть фальш-ярус??",
                            Tags = new List<string> { "fake_tier" },
                        }
                    },

                },
                NoBranch = new QuestionNode
                {
                    Question = "Вам нравятся торты необычной формы (например, сердце, цифра, геометрия)?",
                    Tags = new List<string> { "unique_shape" },
                    YesBranch = new QuestionNode
                    {
                        Question = "Предпочли бы высокий вытянутый торт?",
                        Tags = new List<string> { "tall" },
                        YesBranch = new QuestionNode
                        {
                            Question = "Вы хотите одноярусный торт?",
                            Tags = new List<string> { "single_tier" },
                            NoBranch = new QuestionNode
                            {
                                Question = "В вашем торте может быть фальш-ярус??",
                                Tags = new List<string> { "fake_tier" },
                            }
                        },

                    }
                }
            }
        };

        var secondRoot = new QuestionNode//тематика
        {
            Question = "Торт для дня рождения?",
            Tags = new List<string> { "birthday" },
            YesBranch = new QuestionNode
            {
                Question = "Этот торт для ребёнка?",
                Tags = new List<string> { "child" },
                YesBranch = new QuestionNode
                {
                    Question = "Торт должен соответствовать конкретной тематике?",
                    Tags = new List<string> { "themed_cake" },

                    YesBranch = new QuestionNode
                    {
                        Question = "Торт должен быть вдохновлён природой (горный, лесной, морской стиль)?",
                        Tags = new List<string> { "nature_cake" },

                        YesBranch = new QuestionNode
                        {
                            Question = "Торт для охотника?",
                            Tags = new List<string> { "hunter" },
                            YesBranch = new QuestionNode
                            {
                                //switch
                            },
                            NoBranch = new QuestionNode
                            {
                                Question = "Торт для рыбака?",
                                Tags = new List<string> { "fisherman" },
                                //switch
                            }
                        },
                        NoBranch = new QuestionNode
                        {
                            Question = "Торт для футбольного фаната?",
                            Tags = new List<string> { "football_fan" },
                            YesBranch = new QuestionNode
                            {
                                //switch
                            },
                            NoBranch = new QuestionNode
                            {
                                Question = "Хотите торт, вдохновлённый вашим любимым фильмом, сериалом или мультфильмом?",
                                Tags = new List<string> { "movie_inspired" },
                                YesBranch = new QuestionNode
                                {
                                    //switch
                                },
                                NoBranch = new QuestionNode
                                {
                                    Question = "Нравятся торты в стиле известных брендов (например, Chanel, Louis Vuitton, Gucci)?",
                                    Tags = new List<string> { "brand_style" },
                                    //switch
                                },
                            }
                        }

                    },
                },
                NoBranch = new QuestionNode
                {
                    Question = "Торт для женщины?",
                    Tags = new List<string> { "women" },

                    YesBranch = new QuestionNode
                    {
                        Question = "Торт должен соответствовать конкретной тематике?",
                        Tags = new List<string> { "themed_cake" },

                        YesBranch = new QuestionNode
                        {
                            Question = "Торт должен быть вдохновлён природой (горный, лесной, морской стиль)?",
                            Tags = new List<string> { "nature_cake" },

                            YesBranch = new QuestionNode
                            {
                                Question = "Торт для охотника?",
                                Tags = new List<string> { "hunter" },
                                YesBranch = new QuestionNode
                                {
                                    //switch
                                },
                                NoBranch = new QuestionNode
                                {
                                    Question = "Торт для рыбака?",
                                    Tags = new List<string> { "fisherman" },
                                    //switch
                                }
                            },
                            NoBranch = new QuestionNode
                            {
                                Question = "Торт для футбольного фаната?",
                                Tags = new List<string> { "football_fan" },
                                YesBranch = new QuestionNode
                                {
                                    //switch
                                },
                                NoBranch = new QuestionNode
                                {
                                    Question = "Хотите торт, вдохновлённый вашим любимым фильмом, сериалом или мультфильмом?",
                                    Tags = new List<string> { "movie_inspired" },
                                    YesBranch = new QuestionNode
                                    {
                                        //switch
                                    },
                                    NoBranch = new QuestionNode
                                    {
                                        Question = "Нравятся торты в стиле известных брендов (например, Chanel, Louis Vuitton, Gucci)?",
                                        Tags = new List<string> { "brand_style" },
                                        //switch
                                    },
                                }
                            }

                        },
                    },

                    NoBranch = new QuestionNode
                    {
                        Question = "Торт для мужчины?",
                        Tags = new List<string> { "men" },
                        YesBranch = new QuestionNode
                        {
                            Question = "Торт должен соответствовать конкретной тематике?",
                            Tags = new List<string> { "themed_cake" },

                            YesBranch = new QuestionNode
                            {
                                Question = "Торт должен быть вдохновлён природой (горный, лесной, морской стиль)?",
                                Tags = new List<string> { "nature_cake" },

                                YesBranch = new QuestionNode
                                {
                                    Question = "Торт для охотника?",
                                    Tags = new List<string> { "hunter" },
                                    YesBranch = new QuestionNode
                                    {
                                        //switch
                                    },
                                    NoBranch = new QuestionNode
                                    {
                                        Question = "Торт для рыбака?",
                                        Tags = new List<string> { "fisherman" },
                                        //switch
                                    }
                                },
                                NoBranch = new QuestionNode
                                {
                                    Question = "Торт для футбольного фаната?",
                                    Tags = new List<string> { "football_fan" },
                                    YesBranch = new QuestionNode
                                    {
                                        //switch
                                    },
                                    NoBranch = new QuestionNode
                                    {
                                        Question = "Хотите торт, вдохновлённый вашим любимым фильмом, сериалом или мультфильмом?",
                                        Tags = new List<string> { "movie_inspired" },
                                        YesBranch = new QuestionNode
                                        {
                                            //switch
                                        },
                                        NoBranch = new QuestionNode
                                        {
                                            Question = "Нравятся торты в стиле известных брендов (например, Chanel, Louis Vuitton, Gucci)?",
                                            Tags = new List<string> { "brand_style" },
                                            //switch
                                        },
                                    }
                                }

                            },
                        },
                        NoBranch = new QuestionNode
                        {

                            //switch
                        },
                    }
                }

            },
            NoBranch = new QuestionNode
            {
                Question = "Этот торт для свадьбы или годовщины?",
                Tags = new List<string> { "wedding" },
                YesBranch = new QuestionNode
                {
                    //switch

                },
                NoBranch = new QuestionNode
                {
                    Question = "\"Это торт для сообщения какой-то новости?",
                    Tags = new List<string> { "news_announcement" },
                    YesBranch = new QuestionNode
                    {
                        Question = "Это торт для предложения?",
                        Tags = new List<string> { "proposal" },
                        YesBranch = new QuestionNode
                        {
                            //switch

                        },
                        NoBranch = new QuestionNode
                        {
                            Question = "Это гендерный торт?",
                            Tags = new List<string> { "gender_reveal" },
                            //switch
                        }
                    },
                    NoBranch = new QuestionNode
                    {
                        //switch
                    },

                },
            }

        };

        var thirdRoot = new QuestionNode//надпись на торте
        {
            Question = "Надпись на самом торте — важный элемент?",
            Tags = new List<string> { "inscription_on_cake" },
            YesBranch = new QuestionNode
            {
                Question = "Нравятся торты с тайным посланием (сжигается верхний слой)?",
                Tags = new List<string> { "secret_message" },
                YesBranch = new QuestionNode
                {
                    //switch

                },
                NoBranch = new QuestionNode
                {
                    Question = "Топпер — обязательный элемент для вашего торта?",
                    Tags = new List<string> { "topper" },

                    YesBranch = new QuestionNode
                    {
                        Question = "Хотите украсить торт топпером сверху?",
                        Tags = new List<string> { "topper_on_top" },

                        YesBranch = new QuestionNode
                        {

                            //switch

                        },
                        NoBranch = new QuestionNode
                        {
                            Question = "Предпочитаете топпер, закреплённый сбоку?",
                            Tags = new List<string> { "topper_on_side" },

                            //switch

                        }

                    },
                    NoBranch = new QuestionNode
                    {
                        //switch
                    }
                }
            },
            NoBranch = new QuestionNode
            {
                Question = "Хотели бы разместить фотографию виновника торжества на торте?",
                Tags = new List<string> { "photo_on_cake" },
                YesBranch = new QuestionNode
                {
                    Question = "Торт должен быть шуточный?",
                    Tags = new List<string> { "funny_cake" },
                    //switch

                },
                NoBranch = new QuestionNode
                {
                    //switch
                }
            }
        };

        var forthRoot = new QuestionNode//декор основы
        {
            Question = "Хотите, чтобы торт выглядел 'дорого' и роскошно?",
            Tags = new List<string> { "luxurious" },
            YesBranch = new QuestionNode
            {
                Question = "Хотите, чтобы декор был насыщенным и детализированным?",
                Tags = new List<string> { "detailed_decor" },
                YesBranch = new QuestionNode
                {
                    Question = "Хотите торт в стиле ламбет (объемный, с рюшами и узорами)?",
                    Tags = new List<string> { "lambert" },
                    YesBranch = new QuestionNode
                    {
                        //switch

                    },
                    NoBranch = new QuestionNode
                    {
                        Question = "Нравится, когда торт расписан узорами или рисунками?",
                        Tags = new List<string> { "detailed_decor" },
                        YesBranch = new QuestionNode
                        {
                            //switch

                        },
                        NoBranch = new QuestionNode
                        {
                            Question = "Вам ближе нежные пастельные оттенки?",
                            Tags = new List<string> { "pastel_colors" },
                            YesBranch = new QuestionNode
                            {

                                Question = "Хотите, чтобы торт был белым?",
                                Tags = new List<string> { "white" },
                                //switch
                            },
                            NoBranch = new QuestionNode
                            {
                                Question = "Нравятся яркие, сочные цвета в оформлении?",
                                Tags = new List<string> { "bright_colors" },
                                YesBranch = new QuestionNode
                                {

                                    Question = "Предпочитаете глубокие, тёмные тона?",
                                    Tags = new List<string> { "dark_colors" },

                                    YesBranch = new QuestionNode
                                    {

                                        Question = "Предпочитаете чёрный торт?",
                                        Tags = new List<string> { "black" },
                                        //switch
                                    },

                                    NoBranch = new QuestionNode
                                    {
                                        //switch

                                    },
                                },
                                NoBranch = new QuestionNode
                                {
                                    //switch

                                },
                            },
                        },
                    },
                },
                NoBranch = new QuestionNode
                {
                    Question = "Предпочитаете однотонное оформление торта?",
                    Tags = new List<string> { "solid_color" },

                    YesBranch = new QuestionNode
                    {
                        Question = "Хотите торт с бархатным (велюровым) покрытием?",
                        Tags = new List<string> { "velvet" },

                        YesBranch = new QuestionNode
                        {
                            //switch
                        },
                        NoBranch = new QuestionNode
                        {
                            Question = " Хотите торт в стиле 'голый торт'(naked cake) с минимальным покрытием ? ",
                            Tags = new List<string> { "naked" },

                            YesBranch = new QuestionNode
                            {
                                //switch
                            },
                            NoBranch = new QuestionNode
                            {
                                Question = "Нравятся зеркальные (глянцевые) глазури?",
                                Tags = new List<string> { "mirror_glaze" },
                                //switch
                            }

                        }

                    },
                    NoBranch = new QuestionNode
                    {
                        Question = "Хотите, чтобы торт был украшен мраморным эффеком?",
                        Tags = new List<string> { "marble_effect" },
                        YesBranch = new QuestionNode
                        {
                            //switch
                        },
                        NoBranch = new QuestionNode
                        {
                            Question = "Хотите, чтобы торт был с эффектом омбре (плавный переход цвета)?",
                            Tags = new List<string> { "ombre" },
                            //switch
                        }

                    }
                }
            },
            NoBranch = new QuestionNode
            {
                Question = "Вам по душе минималистичный стиль?",
                Tags = new List<string> { "minimalism" },
                YesBranch = new QuestionNode
                {
                    Question = "Вам ближе нежные пастельные оттенки?",
                    Tags = new List<string> { "pastel_colors" },
                    YesBranch = new QuestionNode
                    {

                        Question = "Хотите, чтобы торт был белым?",
                        Tags = new List<string> { "white" },
                        //switch
                    },
                    NoBranch = new QuestionNode
                    {
                        Question = "Нравятся яркие, сочные цвета в оформлении?",
                        Tags = new List<string> { "bright_colors" },
                        YesBranch = new QuestionNode
                        {

                            Question = "Предпочитаете глубокие, тёмные тона?",
                            Tags = new List<string> { "dark_colors" },

                            YesBranch = new QuestionNode
                            {

                                Question = "Предпочитаете чёрный торт?",
                                Tags = new List<string> { "black" },
                                //switch
                            },

                            NoBranch = new QuestionNode
                            {
                                //switch

                            },
                        },
                        NoBranch = new QuestionNode
                        {
                            //switch

                        },
                    },


                },
                NoBranch = new QuestionNode
                {
                    Question = "Предпочитаете однотонное оформление торта?",
                    Tags = new List<string> { "solid_color" },

                    YesBranch = new QuestionNode
                    {
                        Question = "Хотите торт с бархатным (велюровым) покрытием?",
                        Tags = new List<string> { "velvet" },

                        YesBranch = new QuestionNode
                        {
                            //switch
                        },
                        NoBranch = new QuestionNode
                        {
                            Question = " Хотите торт в стиле 'голый торт'(naked cake) с минимальным покрытием ? ",
                            Tags = new List<string> { "naked" },

                            YesBranch = new QuestionNode
                            {
                                //switch
                            },
                            NoBranch = new QuestionNode
                            {
                                Question = "Нравятся зеркальные (глянцевые) глазури?",
                                Tags = new List<string> { "mirror_glaze" },
                                //switch
                            }

                        }

                    },
                    NoBranch = new QuestionNode
                    {
                        Question = "Хотите, чтобы торт был украшен мраморным эффеком?",
                        Tags = new List<string> { "marble_effect" },
                        YesBranch = new QuestionNode
                        {
                            //switch
                        },
                        NoBranch = new QuestionNode
                        {
                            Question = "Хотите, чтобы торт был с эффектом омбре (плавный переход цвета)?",
                            Tags = new List<string> { "ombre" },
                            //switch
                        }

                    }
                }
            }
        };

        //var tagWeights = new Dictionary<string, double>();

        //foreach (var question in questions)
        //{
        //    Console.WriteLine($"{question.Key} (Да/Нет/Возможно/Не знаю)");
        //    string answer = Console.ReadLine()?.Trim().ToLower();

        //    double weight = answer switch
        //    {
        //        "да" => 1.0,
        //        "нет" => -1.0,
        //        "возможно" => 0.5,
        //        "не знаю" => 0.0,
        //        _ => 0.0
        //    };

        //    tagWeights[question.Value] = weight;
        //}

        //var cakeProbabilities = new Dictionary<int, double>();

        //foreach (var cake in cakes)
        //{
        //    double probability = 0;

        //    foreach (var tag in cake.Tags)
        //    {
        //        if (tagWeights.ContainsKey(tag))
        //        {
        //            probability += tagWeights[tag];
        //        }
        //    }


        //    probability = (probability + tagWeights.Count) / (2 * tagWeights.Count);
        //    cakeProbabilities[cake.Id] = probability;
        //}


        //var topCakes = cakeProbabilities.OrderByDescending(c => c.Value).Take(3);

        

        //Console.WriteLine("\nРекомендуемые торты:");
        //foreach (var cake in topCakes)
        //{
        //    var cakeInfo = cakes.First(c => c.Id == cake.Key);
        //    Console.WriteLine($"ID: {cakeInfo.Id}, Вероятность: {cake.Value:P}, Ссылка: {cakeInfo.Photo}");
        //}

    }

    
}
