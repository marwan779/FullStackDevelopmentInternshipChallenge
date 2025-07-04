# 🛒 E-Commerce Checkout System – Fawry Internship Challenge

This project is a console-based E-Commerce Checkout System developed in **C#** for the **Fawry Quantum Summer Internship Challenge**.

It demonstrates key object-oriented programming concepts, including inheritance, encapsulation, interfaces, polymorphism, and clean business logic separation.

---

## 📌 Features

✅ Define products with:
- Name, Price, Quantity  
- Optional Expiration Date  
- Optional Shipping Weight  

✅ Product types:
- **Standard Product**
- **Expirable Product** (e.g. Milk, Cheese)
- **Shippable Product** (e.g. TV)
- **Expirable & Shippable Product** (e.g. Cheese)

✅ Cart & Checkout Functionality:
- Add product with a valid quantity (not more than stock and not expired)
- Prevent adding 0 quantity or expired products
- Handle checkout errors:
  - Empty cart
  - Insufficient customer balance
  - Out-of-stock or expired products
- Calculate and print:
  - Subtotal
  - Shipping cost (based on total weight)
  - Total amount
  - Updated customer balance
- Send shippable products to a shipping service

✅ Shipping Service:
- Accepts a list of shippable items (via interface)
- Displays total shipment weight and items

---

## 🧪 Test Coverage

The project includes a variety of tests to validate system behavior:

| Test Case | Description |
|----------|-------------|
| ✅ Successful Checkout | Multiple items (shippable & non-shippable) |
| ✅ Add More Than Available | Prevents over-ordering |
| ✅ Empty Cart Checkout | Shows appropriate error |
| ✅ Expired Product | Rejects expired products |
| ✅ Insufficient Balance | Prevents checkout |
| ✅ Mixed Product Types | Supports all combinations |
| ✅ Zero Quantity | Prevents logically invalid addition |
| ✅ Stock Reduction | Quantity decreases after checkout |
| ✅ No Shippable Items | Skips shipping step if not needed |
| ✅ Repeated Product | Multiple adds handled correctly |

---

## 🛠 Technologies Used

- C# (.NET 8.0)
- Object-Oriented Design
- Console Application

---

## 📂 Project Structure

/FawryChallenge
│
├── Program.cs # Main entry with test cases
├── Models/
│ ├── BaseProduct.cs
│ ├── ExpirableProduct.cs
│ ├── ShippableProduct.cs
│ ├── ExpirableShippableProduct.cs
| ├── Cart.cs
| ├── CartItem.cs
| └── Customer.cs
├── Services/
│ ├── CheckOutService.cs
│ ├── ShippingService.cs
| └── IShippable.cs
├── Testing/
│ ├── TestingCases.cs

## Console Output


--- Test: Successful Checkout ---
** Shipment notice **
2x Cheese
Total package weight 0.8kg

** Checkout receipt **
2x Cheese       10
1x Scratch Card 10
----------------------
Subtotal        20
Shipping        8
Amount          28
Balance left    972




--- Test: Add More Than Available ---
Error: Cannot add 3 of TV. Only 2 available.




--- Test: Empty Cart Checkout ---
Error: The cart is currently empty !




--- Test: Checkout With Expired Product ---
Error: Cannot add Milk because it is expired.
Error: The cart is currently empty !




--- Test: Insufficient Balance ---
Error: Insufficient balance.




--- Test: Mixed Expirable & Shippable Products ---
** Shipment notice **
2x Cheese
1x TV
Total package weight 1.8kg

** Checkout receipt **
2x Cheese       6
1x Biscuits     2
1x TV   2
1x Scratch Card 5
----------------------
Subtotal        15
Shipping        18
Amount          33
Balance left    1967




--- Test: Add Zero Quantity ---
Error: Cannot add 0 of TestItem. Quantity must be greater than 0.




--- Test: Stock Decreases After Checkout ---
** Checkout receipt **
2x Battery      60
----------------------
Subtotal        60
Shipping        0
Amount          60
Balance left    440
Remaining stock for Battery: 3 (Expected: 3)




--- Test: No Shippable Items ---
** Checkout receipt **
2x Scratch Card 10
----------------------
Subtotal        10
Shipping        0
Amount          10
Balance left    490




--- Test: Multiple Same Product ---
** Shipment notice **
4x TV
Total package weight 3.2kg

** Checkout receipt **
2x TV   10
2x TV   10
----------------------
Subtotal        20
Shipping        32
Amount          52
Balance left    948

📣 Author
Marwan Mohamed
Passionate about .NET development, clean architecture, and problem solving.

