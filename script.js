let count = 0;
const cartDisplay = document.querySelector('.cart-count');
const buttons = document.querySelectorAll('.add-to-cart');

buttons.forEach(button => {
    button.addEventListener('click', () => {
        count++;
        cartDisplay.textContent = count;
    });
});
