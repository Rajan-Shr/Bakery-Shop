const Quantity = document.querySelector("#Quantity") as HTMLInputElement;
const UnitPrice = document.querySelector("#UnitPrice") as HTMLInputElement;
const TotalPrice = document.querySelector("#TotalPrice") as HTMLSpanElement;

if (Quantity && UnitPrice && TotalPrice) {
    Quantity.addEventListener("change", () => {
        const UnitPriceValue = Number(UnitPrice.value);
        const QuantityValue = Number(Quantity.value);
        const TotalPriceValue = UnitPriceValue * QuantityValue;
        TotalPrice.textContent = TotalPriceValue.toString();
    })
}
