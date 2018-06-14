Select Restaurants.RestaurantName, Food.FoodName, PathElements.Price From Restaurants
JOIN PathElements ON Restaurants.Id=PathElements.RestaurantId
JOIN Food ON Food.Id = PathElements.FoodId
WHERE 
 Food.FoodName = 'water' ;



