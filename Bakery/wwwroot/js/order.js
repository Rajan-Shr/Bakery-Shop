"use strict";
const Quantity = document.querySelector("#Quantity");
const UnitPrice = document.querySelector("#UnitPrice");
const TotalPrice = document.querySelector("#TotalPrice");
if (Quantity && UnitPrice && TotalPrice) {
    Quantity.addEventListener("change", () => {
        const UnitPriceValue = Number(UnitPrice.value);
        const QuantityValue = Number(Quantity.value);
        const TotalPriceValue = UnitPriceValue * QuantityValue;
        TotalPrice.textContent = TotalPriceValue.toString();
    });
}
