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
│ ├── Cart.cs
│ ├── CartItem.cs
│ └── Customer.cs
├── Services/
│ ├── CheckOutService.cs
│ ├── ShippingService.cs
│ └── IShippable.cs
├── Testing/
│ └── TestingCases.cs

---

## Console Output

![Screenshot (220)](https://github.com/user-attachments/assets/c2382a6b-860b-4fdc-85a3-e6df94afbd80)
![Screenshot (221)](https://github.com/user-attachments/assets/c20f01f6-5cd9-4445-a491-aca18b9db348)
![Screenshot (222)](https://github.com/user-attachments/assets/2ed1209c-664f-4745-bff8-f160ad1b342a)


📣 Author
Marwan Mohamed
Passionate about .NET development, clean architecture, and problem solving.

