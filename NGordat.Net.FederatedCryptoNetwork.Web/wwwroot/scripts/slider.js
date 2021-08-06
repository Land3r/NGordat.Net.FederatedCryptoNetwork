var slide = new Array("/images/faucets/faucetcrypto/1.png", "/images/faucets/faucetcrypto/2.png", "/images/faucets/faucetcrypto/3.png");
var numero = 0;

function ChangeSlide(sens) {
    numero = numero + sens;
    if (numero < 0)
        numero = slide.length - 1;
    if (numero > slide.length - 1)
        numero = 0;
    document.getElementById("slide").src = slide[numero];
}