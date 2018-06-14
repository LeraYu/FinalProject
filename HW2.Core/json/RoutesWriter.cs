using System;
using System.Collections.Generic;
using TP.Core.transport;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static TP.Core.transport.Restaurant;

namespace TP.Core.json
{
    public class RestaurantWriter : Writer
    {
        public static void Write()
        {
            var breakfast = new Time()
            {
                TimeOfEat = "Breakfast"
            };

            var dinner = new Time()
            {
                TimeOfEat = "Dinner"
            };

            var lunch = new Time()
            {
                TimeOfEat = "Lunch"
            };

            var americano = new Food()
            {
                Id = 1,
                FoodName = "Americano"
            };

            var englishbreakfast = new Food()
            {
                Id = 19,
                FoodName = "English breakfast"
            };

            var bagel = new Food()
            {
                Id = 21,
                FoodName = "Bagle with turkey"
            };

            var beefstroganoff = new Food()
            {
                Id = 24,
                FoodName = "Beef stroganoff"
            };

            var hamandcheese = new Food()
            {
                Id = 28,
                FoodName = "Sandwich with ham and cheese"
            };

            var caviare = new Food()
            {
                Id = 37,
                FoodName = "Pancakes with caviar"
            };

            var meet = new Food()
            {
                Id = 43,
                FoodName = "Bakes"
            };

            var strawberry = new Food()
            {
                Id = 49,
                FoodName = "Bakes with strawberry"
            };

            var pancakeswithapple = new Food()
            {
                Id = 50,
                FoodName = "Bakes with apples"
            };

            var borcht = new Food()
            {
                Id = 56,
                FoodName = "Borsh"
            };

            var cherry = new Food()
            {
                Id = 59,
                FoodName = "Vareniki"
            };

            var mashrooms = new Food()
            {
                Id = 63,
                FoodName = "Vareniki with potatoes and mushrooms"
            };

            var egg = new Food()
            {
                Id = 65,
                FoodName = "Eggs with toast and jam"
            };

            var water = new Food()
            {
                Id = 66,
                FoodName = "Water"
            };

            var softdrinks = new Food()
            {
                Id = 84,
                FoodName = "Soft drink"
            };

            var doubleespresso = new Food()
            {
                Id = 93,
                FoodName = "Double espresso"
            };

            var latke = new Food()
            {
                Id = 102,
                FoodName = "Latke"
            };

            var potato = new Food()
            {
                Id = 106,
                FoodName = "Home fries with mushrooms"
            };

            var casserole = new Food()
            {
                Id = 108,
                FoodName = "Casserole"
            };

            var greentea = new Food()
            {
                Id = 114,
                FoodName = "Green tea"
            };

            var yogurt = new Food()
            {
                Id = 129,
                FoodName = "Yougurt with fresh berries"
            };

            var cappuccino = new Food()
            {
                Id = 130,
                FoodName = "Cappuccino"
            };

            var rackoflamb = new Food()
            {
                Id = 148,
                FoodName = "Rack of lamb"
            };

            var oatmeal = new Food()
            {
                Id = 154,
                FoodName = "Oatmeal"
            };

            var riceporridge = new Food()
            {
                Id = 156,
                FoodName = "Rice porridge"
            };

            var compote = new Food()
            {
                Id = 157,
                FoodName = "Compote"
            };

            var cutlet = new Food()
            {
                Id = 159,
                FoodName = "chiken Kiev"
            };

            var cremebrule = new Food()
            {
                Id = 163,
                FoodName = "Cream brulee"
            };

            var creamsoup = new Food()
            {
                Id = 169,
                FoodName = "Cream of champignons"
            };

            var lasagne = new Food()
            {
                Id = 175,
                FoodName = "Lasagna"
            };

            var latte = new Food()
            {
                Id = 179,
                FoodName = "Latte"
            };

            var macaroni = new Food()
            {
                Id = 197,
                FoodName = "Navi macaroni"
            };

            var morse = new Food()
            {
                Id = 199,
                FoodName = "Morse"
            };

            var napoleon = new Food()
            {
                Id = 201,
                FoodName = "Cake Napoleon"
            };

            var summersoup = new Food()
            {
                Id = 207,
                FoodName = "Summer soup"
            };

            var squash = new Food()
            {
                Id = 211,
                FoodName = "Squash pancakes"
            };

            var bolognese = new Food()
            {
                Id = 215,
                FoodName = "Pasta Bolognese"
            };

            var carbonara = new Food()
            {
                Id = 219,
                FoodName = "Pasta Carbonara"
            };

            var pate = new Food()
            {
                Id = 223,
                FoodName = "Pate"
            };

            var ravioli = new Food()
            {
                Id = 227,
                FoodName = "Dumplings"
            };

            var creampuffs = new Food()
            {
                Id = 231,
                FoodName = "Cream puffs"
            };


            var pickle = new Food()
            {
                Id = 237,
                FoodName = "Picle soup"
            };

            var rissotowithseafood = new Food()
            {
                Id = 241,
                FoodName = "Rissoto with seafood"
            };

            var rissotowithvegetables = new Food()
            {
                Id = 245,
                FoodName = "Rissoto with vegetables"
            };

            var nice = new Food()
            {
                Id = 249,
                FoodName = "Nice Salad"
            };

            var caesarwithshrips = new Food()
            {
                Id = 253,
                FoodName = "Caesar Salad with shrimps"
            };

            var caesarwithchicken = new Food()
            {
                Id = 255,
                FoodName = "Salad Caesae with chicken"
            };

            var tomatosalad = new Food()
            {
                Id = 261,
                FoodName = "Salad with tomatoes and cheese"
            };

            var vegetablesalad = new Food()
            {
                Id = 263,
                FoodName = "Vegetable Salad"
            };

            var saladwithshrimps = new Food()
            {
                Id = 269,
                FoodName = "Salad with shrimps"
            };

            var saladwithroastbeef = new Food()
            {
                Id = 275,
                FoodName = "Salad with roastbeef"
            };

            var saladwithsalmon = new Food()
            {
                Id = 279,
                FoodName = "Salad with salmon"
            };

            var freshjuice = new Food()
            {
                Id = 281,
                FoodName = "Fresh juice"
            };

            var herring = new Food()
            {
                Id = 293,
                FoodName = "Herring"
            };

            var mackerel = new Food()
            {
                Id = 295,
                FoodName = "Grilled mackerel"
            };

            var smoothie = new Food()
            {
                Id = 299,
                FoodName = "Smoothie"
            };

            var juice = new Food()
            {
                Id = 305,
                FoodName = "Juice"
            };

            var beefsteak = new Food()
            {
                Id = 317,
                FoodName = "Beefsteak"
            };

            var salmon = new Food()
            {
                Id = 321,
                FoodName = "Salmon steak"
            };

            var chickensoup = new Food()
            {
                Id = 325,
                FoodName = "Chicken soup"
            };

            var syrniki = new Food()
            {
                Id = 331,
                FoodName = "Syrniki with sour cream"
            };

            var sandwichwithveg = new Food()
            {
                Id = 334,
                FoodName = "Sandwich with vegetables"
            };

            var sandwichwithchicken = new Food()
            {
                Id = 337,
                FoodName = "Sandwich with chicken"
            };

            var sandwichwithsalmon = new Food()
            {
                Id = 343,
                FoodName = "Sandwich with salmon"
            };

            var tiramisu = new Food()
            {
                Id = 349,
                FoodName = "Tiramisu"
            };

            var tomatosoup = new Food()
            {
                Id = 355,
                FoodName = "Tomato soup"
            };

            var filetmignon = new Food()
            {
                Id = 361,
                FoodName = "Filet mignon"
            };

            var croissant = new Food()
            {
                Id = 363,
                FoodName = "Croissant"
            };

            var fruitsalad = new Food()
            {
                Id = 366,
                FoodName = "Fruit salad"
            };

            var blacktea = new Food()
            {
                Id = 368,
                FoodName = "Black tea"
            };

            var cheesecake = new Food()
            {
                Id = 383,
                FoodName = "Cheesecake"
            };

            var chocolate = new Food()
            {
                Id = 389,
                FoodName = "Chocolate muffin"
            };

            var espresso = new Food()
            {
                Id = 398,
                FoodName = "Espresso"
            };

            var applepie = new Food()
            {
                Id = 416,
                FoodName = "Apple pie"
            };





            var json = JsonConvert.SerializeObject(
                new Content(
                    new List<Food>
                    {
                     americano,
                     englishbreakfast,
                     bagel,
                     beefstroganoff,
                     hamandcheese,
                     caviare,
                     meet,
                     strawberry,
                     pancakeswithapple,
                     borcht,
                     cherry,
                     mashrooms,
                     egg,
                     water,
                     softdrinks,
                     doubleespresso,
                     latke,
                     potato,
                     casserole,
                     greentea,
                     yogurt,
                     cappuccino,
                     rackoflamb,
                     oatmeal,
                     riceporridge,
                     compote,
                     cutlet,
                     cremebrule,
                     creamsoup,
                     lasagne,
                     latte,
                     macaroni,
                     morse,
                     napoleon,
                     summersoup,
                     squash,
                     bolognese,
                     carbonara,
                     pate,
                     ravioli,
                     creampuffs,
                     pickle,
                     rissotowithseafood,
                     rissotowithvegetables,
                     nice,
                     caesarwithchicken,
                     caesarwithshrips,
                     tomatosalad,
                     vegetablesalad,
                     saladwithroastbeef,
                     saladwithsalmon,
                     saladwithshrimps,
                     freshjuice,
                     herring,
                     mackerel,
                     smoothie,
                     juice,
                     beefsteak,
                     salmon,
                     chickensoup,
                     syrniki,
                     sandwichwithchicken,
                     sandwichwithsalmon,
                     sandwichwithveg,
                     tiramisu,
                     tomatosoup,
                     filetmignon,
                     croissant,
                     fruitsalad,
                     blacktea,
                     cheesecake,
                     chocolate,
                     espresso,
                     applepie

                    },
                new List<Restaurant>
                {
                    new Restaurant()
                    {
                        RestaurantName="Breakfast",
                        Id=1,
                        Path = new List<PathElement>
                        {
                           new PathElement()
                            {
                                Id = 1,
                                FoodId = americano.Id,
                                Time = breakfast,
                                Price = 259
                            },

                            new PathElement()
                            {
                                 Id = 2,
                                 FoodId = americano.Id,
                                 Time = lunch,
                                 Price = 259
                            },

                            new PathElement()
                            {
                                Id = 3,
                                FoodId = americano.Id,
                                Time = dinner,
                                 Price = 259
                            },
                            new PathElement()
                            {
                                Id = 19,
                                FoodId = englishbreakfast.Id,
                                Time = breakfast,
                                Price = 470
                            },
                            new PathElement()
                            {
                                Id = 21,
                                FoodId = bagel.Id,
                                Time = breakfast,
                                Price = 159
                            },

                            new PathElement()
                            {
                                Id = 22,
                                FoodId = bagel.Id,
                                Time = lunch,
                                Price = 159
                            },

                            new PathElement()
                                {
                                    Id = 23,
                                    FoodId = bagel.Id,
                                    Time = dinner,
                                    Price = 159
                                },
                            new PathElement()
                                {
                                    Id = 28,
                                    FoodId = hamandcheese.Id,
                                    Time = breakfast,
                                    Price = 259
                                },

                            new PathElement()
                                {
                                    Id = 29,
                                    FoodId = hamandcheese.Id,
                                    Time = lunch,
                                    Price = 259
                                },

                            new PathElement()
                                {
                                    Id = 30,
                                    FoodId = hamandcheese.Id,
                                    Time = dinner,
                                    Price = 259
                                },
                            new PathElement()
                                {
                                    Id = 49,
                                    FoodId = strawberry.Id,
                                    Time = breakfast,
                                    Price = 280
                                },
                            new PathElement()
                                {
                                    Id = 61,
                                    FoodId = cherry.Id,
                                    Time = dinner,
                                    Price = 280
                                },

                            new PathElement()
                                {
                                    Id = 62,
                                    FoodId = cherry.Id,
                                    Time = lunch,
                                    Price = 280
                                },
                            new PathElement()
                                {
                                    Id = 66,
                                    FoodId = water.Id,
                                    Time = breakfast,
                                    Price = 99
                                },

                            new PathElement()
                                {
                                    Id = 67,
                                    FoodId = water.Id,
                                    Time = lunch,
                                    Price = 99
                                },


                            new PathElement()
                                {
                                    Id = 68,
                                    FoodId = water.Id,
                                    Time = dinner,
                                    Price = 99
                                },
                            new PathElement()
                                {
                                    Id = 84,
                                    FoodId = softdrinks.Id,
                                    Time = breakfast,
                                    Price = 149
                                },

                            new PathElement()
                                {
                                    Id = 85,
                                    FoodId = softdrinks.Id,
                                    Time = lunch,
                                    Price = 149
                                },

                            new PathElement()
                                {
                                    Id = 86,
                                    FoodId = softdrinks.Id,
                                    Time = dinner,
                                    Price = 149
                                },
                            new PathElement()
                                {
                                    Id = 114,
                                    FoodId = greentea.Id,
                                    Time = breakfast,
                                    Price = 270
                                },

                            new PathElement()
                                {
                                    Id = 115,
                                    FoodId = greentea.Id,
                                    Time = lunch,
                                    Price = 270
                                },

                            new PathElement()
                                {
                                    Id = 116,
                                    FoodId = greentea.Id,
                                    Time = dinner,
                                    Price = 270
                                },
                            new PathElement()
                                {
                                    Id = 129,
                                    FoodId = yogurt.Id,
                                    Time = breakfast,
                                    Price = 270
                                },
                            new PathElement()
                                {
                                    Id = 130,
                                    FoodId = cappuccino.Id,
                                    Time = breakfast,
                                    Price = 259
                                },

                            new PathElement()
                                {
                                    Id = 131,
                                    FoodId = cappuccino.Id,
                                    Time = lunch,
                                    Price = 259
                                },

                            new PathElement()
                                {
                                    Id = 132,
                                    FoodId = cappuccino.Id,
                                    Time = dinner,
                                    Price = 259
                                },
                            new PathElement()
                                {
                                    Id = 154,
                                    FoodId = oatmeal.Id,
                                    Time = breakfast,
                                    Price = 210
                                },
                            new PathElement()
                                {
                                    Id = 156,
                                    FoodId = riceporridge.Id,
                                    Time = breakfast,
                                    Price = 210
                                },
                            new PathElement()
                                {
                                    Id = 179,
                                    FoodId = latte.Id,
                                    Time = breakfast,
                                    Price = 259
                                },

                            new PathElement()
                                {
                                    Id = 180,
                                    FoodId = latte.Id,
                                    Time = lunch,
                                    Price = 259
                                },

                            new PathElement()
                                {
                                    Id = 181,
                                    FoodId = latte.Id,
                                    Time = dinner,
                                    Price = 259
                                },
                            new PathElement()
                                {
                                    Id = 305,
                                    FoodId = juice.Id,
                                    Time = breakfast,
                                    Price = 129
                                },

                            new PathElement()
                                {
                                    Id = 306,
                                    FoodId = juice.Id,
                                    Time = lunch,
                                    Price = 129
                                },

                            new PathElement()
                                {
                                    Id = 307,
                                    FoodId = juice.Id,
                                    Time = dinner,
                                    Price = 129
                                },
                            new PathElement()
                                {
                                    Id = 331,
                                    FoodId = syrniki.Id,
                                    Time = breakfast,
                                    Price = 250
                                },


                            new PathElement()
                                {
                                    Id = 363,
                                    FoodId = croissant.Id,
                                    Time = breakfast,
                                    Price = 115
                                },

                            new PathElement()
                                {
                                    Id = 398,
                                    FoodId = espresso.Id,
                                    Time = breakfast,
                                    Price = 199
                                },

                            new PathElement()
                                {
                                    Id = 399,
                                    FoodId = espresso.Id,
                                    Time = lunch,
                                    Price = 199
                                },

                            new PathElement()
                                {
                                    Id = 400,
                                    FoodId = espresso.Id,
                                    Time = dinner,
                                    Price = 199
                                },
                        }
                    },

                    new Restaurant()
                    {
                        RestaurantName="ChillLounge",
                        Id=2,

                        Path = new List<PathElement>
                        {
                            new PathElement()
                                {
                                    Id = 4,
                                    FoodId = americano.Id,
                                    Time = breakfast,
                                    Price = 179
                                },

                            new PathElement()
                                {
                                    Id = 5,
                                    FoodId = americano.Id,
                                    Time = lunch,
                                    Price = 179
                                },

                            new PathElement()
                                {
                                    Id = 6,
                                    FoodId = americano.Id,
                                    Time = dinner,
                                    Price = 179
                                },
                            new PathElement()
                                {
                                    Id = 21,
                                    FoodId = bagel.Id,
                                    Time = breakfast,
                                    Price = 159
                                },

                            new PathElement()
                                {
                                    Id = 22,
                                    FoodId = bagel.Id,
                                    Time = lunch,
                                    Price = 159
                                },

                            new PathElement()
                                {
                                    Id = 23,
                                    FoodId = bagel.Id,
                                    Time = dinner,
                                    Price = 159
                                },
                            new PathElement()
                                {
                                    Id = 31,
                                    FoodId = hamandcheese.Id,
                                    Time = breakfast,
                                    Price = 119
                                },

                            new PathElement()
                                {
                                    Id = 32,
                                    FoodId = hamandcheese.Id,
                                    Time = lunch,
                                    Price = 119
                                },

                            new PathElement()
                                {
                                    Id = 33,
                                    FoodId = hamandcheese.Id,
                                    Time = dinner,
                                    Price = 119
                                },
                            new PathElement()
                                {
                                    Id = 43,
                                    FoodId = meet.Id,
                                    Time = breakfast,
                                    Price = 149
                                },

                            new PathElement()
                                {
                                    Id = 44,
                                    FoodId = meet.Id,
                                    Time = lunch,
                                    Price = 149
                                },

                            new PathElement()
                                {
                                    Id = 45,
                                    FoodId = meet.Id,
                                    Time = dinner,
                                    Price = 149
                                },
                            new PathElement()
                                {
                                    Id = 56,
                                    FoodId = borcht.Id,
                                    Time = lunch,
                                    Price = 199
                                },
                            new PathElement()
                                {
                                    Id = 69,
                                    FoodId = water.Id,
                                    Time = breakfast,
                                    Price = 99
                                },

                            new PathElement()
                                {
                                    Id = 70,
                                    FoodId = water.Id,
                                    Time = lunch,
                                    Price = 99
                                },

                            new PathElement()
                                {
                                    Id = 71,
                                    FoodId = water.Id,
                                    Time = dinner,
                                    Price = 99
                                },

                        }
                    },

                    new Restaurant()
                    {
                        RestaurantName="Uruk",
                        Id=3,

                        Path = new List<PathElement>
                        {
                            new PathElement()
                            {
                                Id = 1,
                                FoodId = americano.Id,
                                Time = breakfast,
                                Price = 259
                            },

                        new PathElement()
                            {
                                Id = 2,
                                FoodId = americano.Id,
                                Time = lunch,
                                Price = 259
                            },

                        new PathElement()
                            {
                                Id = 3,
                                FoodId = americano.Id,
                                Time = dinner,
                                Price = 259
                            },

                        new PathElement()
                            {
                                Id = 24,
                                FoodId = beefstroganoff.Id,
                                Time = lunch,
                                Price = 349
                            },

                        new PathElement()
                            {
                                Id = 25,
                                FoodId = beefstroganoff.Id,
                                Time = dinner,
                                Price = 349
                            },
                        new PathElement()
                            {
                                Id = 28,
                                FoodId = hamandcheese.Id,
                                Time = breakfast,
                                Price = 259
                            },

                        new PathElement()
                            {
                                Id = 29,
                                FoodId = hamandcheese.Id,
                                Time = lunch,
                                Price = 259
                            },

                        new PathElement()
                            {
                                Id = 30,
                                FoodId = hamandcheese.Id,
                                Time = dinner,
                                Price = 259
                            },
                        new PathElement()
                            {
                                Id = 40,
                                FoodId = caviare.Id,
                                Time = breakfast,
                                Price = 380
                            },

                        new PathElement()
                            {
                                Id = 41,
                                FoodId = caviare.Id,
                                Time = lunch,
                                Price = 380
                            },

                        new PathElement()
                            {
                                Id = 42,
                                FoodId = caviare.Id,
                                Time = dinner,
                                Price = 380
                            },
                        new PathElement()
                                {
                                    Id = 368,
                                    FoodId = blacktea.Id,
                                    Time = breakfast,
                                    Price = 270
                                },

                        new PathElement()
                                {
                                    Id = 369,
                                    FoodId = blacktea.Id,
                                    Time = lunch,
                                    Price = 270
                                },

                        new PathElement()
                                {
                                    Id = 370,
                                    FoodId = blacktea.Id,
                                    Time = dinner,
                                    Price = 270
                                }
                        }
                    },
                new Restaurant()
                    {
                        RestaurantName="Sixty",
                        Id=4,

                        Path = new List<PathElement>
                        {

                            new PathElement()
                                {
                                    Id = 46,
                                    FoodId = meet.Id,
                                    Time = breakfast,
                                    Price = 179
                                },

                            new PathElement()
                                {
                                    Id = 47,
                                    FoodId = meet.Id,
                                    Time = lunch,
                                    Price = 179
                                },

                            new PathElement()
                                {
                                    Id = 48,
                                    FoodId = meet.Id,
                                    Time = dinner,
                                    Price = 179
                                },
                            new PathElement()
                                {
                                    Id = 50,
                                    FoodId = pancakeswithapple.Id,
                                    Time = breakfast,
                                    Price = 119
                                },

                            new PathElement()
                                {
                                    Id = 51,
                                    FoodId = pancakeswithapple.Id,
                                    Time = lunch,
                                    Price = 119
                                },

                            new PathElement()
                                {
                                    Id = 52,
                                    FoodId = pancakeswithapple.Id,
                                    Time = dinner,
                                    Price = 119
                                },
                            new PathElement()
                                {
                                    Id = 58,
                                    FoodId = borcht.Id,
                                    Time = lunch,
                                    Price = 430
                                },

                            new PathElement()
                                {
                                    Id = 59,
                                    FoodId = cherry.Id,
                                    Time = dinner,
                                    Price = 330
                                },

                            new PathElement()
                                {
                                    Id = 60,
                                    FoodId = cherry.Id,
                                    Time = lunch,
                                    Price = 330
                                },
                              new PathElement()
                                {
                                    Id = 337,
                                    FoodId = sandwichwithchicken.Id,
                                    Time = breakfast,
                                    Price = 240
                                },

                            new PathElement()
                                {
                                    Id = 338,
                                    FoodId = sandwichwithchicken.Id,
                                    Time = lunch,
                                    Price = 240
                                },

                            new PathElement()
                                {
                                    Id = 339,
                                    FoodId = sandwichwithchicken.Id,
                                    Time = dinner,
                                    Price = 240
                                },
                        }
                },
                new Restaurant()
                    {
                        RestaurantName="Stolovaya",
                        Id=5,

                        Path = new List<PathElement>
                        {
                            new PathElement()
                                {
                                    Id = 75,
                                    FoodId = water.Id,
                                    Time = breakfast,
                                    Price = 170
                                },

                            new PathElement()
                                {
                                    Id = 76,
                                    FoodId = water.Id,
                                    Time = lunch,
                                    Price = 170
                                },

                            new PathElement()
                                {
                                    Id = 77,
                                    FoodId = water.Id,
                                    Time = dinner,
                                    Price = 170
                                },

                            new PathElement()
                                {
                                    Id = 87,
                                    FoodId = softdrinks.Id,
                                    Time = breakfast,
                                    Price = 129
                                },

                            new PathElement()
                                {
                                    Id = 88,
                                    FoodId = softdrinks.Id,
                                    Time = lunch,
                                    Price = 129
                                },

                            new PathElement()
                                {
                                    Id = 89,
                                    FoodId = softdrinks.Id,
                                    Time = dinner,
                                    Price = 129
                                },
                            new PathElement()
                                {
                                    Id = 117,
                                    FoodId = greentea.Id,
                                    Time = breakfast,
                                    Price = 119
                                },

                            new PathElement()
                                {
                                    Id = 118,
                                    FoodId = greentea.Id,
                                    Time = lunch,
                                    Price = 119
                                },

                            new PathElement()
                                {
                                    Id = 119,
                                    FoodId = greentea.Id,
                                    Time = dinner,
                                    Price = 119
                                },
                            new PathElement()
                                {
                                    Id = 133,
                                    FoodId = cappuccino.Id,
                                    Time = breakfast,
                                    Price = 179
                                },

                            new PathElement()
                                {
                                    Id = 134,
                                    FoodId = cappuccino.Id,
                                    Time = lunch,
                                    Price = 179
                                },

                            new PathElement()
                                {
                                    Id = 135,
                                    FoodId = cappuccino.Id,
                                    Time = dinner,
                                    Price = 179
                                },
                            new PathElement()
                                {
                                    Id = 152,
                                    FoodId = rackoflamb.Id,
                                    Time = lunch,
                                    Price = 950
                                },

                            new PathElement()
                                {
                                    Id = 153,
                                    FoodId = rackoflamb.Id,
                                    Time = dinner,
                                    Price = 950
                                },
                            new PathElement()
                                {
                                    Id = 182,
                                    FoodId = latte.Id,
                                    Time = breakfast,
                                    Price = 229
                                },

                            new PathElement()
                                {
                                    Id = 183,
                                    FoodId = latte.Id,
                                    Time = lunch,
                                    Price = 229
                                },

                            new PathElement()
                                {
                                    Id = 184,
                                    FoodId = latte.Id,
                                    Time = dinner,
                                    Price = 229
                                },
                        }
                }
                }

                ));
            WriteToFile("rest.json", json);
        }
    }
}