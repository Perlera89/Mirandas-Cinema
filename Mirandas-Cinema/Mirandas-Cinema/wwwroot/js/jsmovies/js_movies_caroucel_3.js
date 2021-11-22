  const fila3 = document.querySelector('.carousel3');
const pelicula3 = document.querySelectorAll('.pelicula3');

const flechaIzquierda3 = document.getElementById('flecha_izquierda3');
const flechaDerecha3 = document.getElementById('flecha_derecha3');

/*-------flecha derecha------*/
flechaDerecha3.addEventListener('click', () => {
    fila3.scrollLeft += fila3.offsetWidth;

    const indicadorActivo = document.querySelector('.indicadores3 .activo');
    //preguntando si hay un elemento a la derecha
    if (indicadorActivo.nextSibling) {
        indicadorActivo.nextSibling.classList.add('activo');
        indicadorActivo.classList.remove('activo');
    }
});

flechaIzquierda3.addEventListener('click', () => {

    fila3.scrollLeft -= fila3.offsetWidth;
    const indicadorActivo = document.querySelector('.indicadores3 .activo');
    //preguntando si hay un elemento a la derecha
    if (indicadorActivo.previousSibling) {
        indicadorActivo.previousSibling.classList.add('activo');
        indicadorActivo.classList.remove('activo');
    }
});

/*------paginacion------*/
const numeroPaginas3 = Math.ceil(pelicula3.length / 5);
for (let i = 0; i < numeroPaginas3; i++) {
    const indicador = document.createElement('button');

    if (i === 0) {
        indicador.classList.add('activo');
    }

    document.querySelector('.indicadores3').appendChild(indicador);
    indicador.addEventListener('click', (e) => {
        fila3.scrollLeft += i * fila3.offsetWidth;

        document.querySelector('.indicadores3 .activo').classList.remove('activo');
        /*el botton clickeado*/
        e.target.classList.add('activo');
    });
}
function Desactivar() {
    const numeroPeliculas3 = Math.ceil(pelicula3.length);
    /*----carousel 3----*/
    if (numeroPeliculas3 <= 5) {
        flechaIzquierda3.classList.add('desactivar');
        flechaDerecha3.classList.add('desactivar');
        document.querySelector('.indicadores3').classList.add('desactivar');
    }
    else {
        flechaIzquierda3.classList.remove('desactivar');
        flechaDerecha3.classList.remove('desactivar');
        document.querySelector('.indicadores3').classList.remove('desactivar');
    }

}
Desactivar();

//hover

pelicula3.forEach((pelicula3) => {
    pelicula3.addEventListener('mouseenter', (e) => {
        const elemento = e.currentTarget;
        setTimeout(() => {
            for (var i = 0; i < pelicula3; i++) {
                pelicula3 => pelicula3.classList.remove('hover');
            }

            elemento.classList.add('hover');
        }, 300);
    });
});

fila3.addEventListener('mouseleave', () => {
    pelicula3.forEach(pelicula3 => pelicula3.classList.remove('hover'));

});