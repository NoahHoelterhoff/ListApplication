# Tasks
* Calculate Basket Total: Develop functionality to calculate the total price of all items in a customer's basket.
  * If a customer purchases the same item more than five times, they should receive a 10% discount on that specific item.
  * Customers have a membership that gives a discount on the complete shopping cart at the end. Please take this into account.
  * Most of the logic should be in the MainProgram CalculateTotal method. The input is the customer (including his membership and the products in his shopping basket) and the return should be the total price.
* Optional Additional Tasks:
  * WinForms: Implement the ability to remove items from both the customer and the product lists within the user interface.
  * API: The current total price is only shown in EUR but should also be displayed in USD. Use the public API `https://open.er-api.com/v6/latest/EUR` to get the current exchange rate. Implement it in the FromEURToUSD method inside of the MainProgram
