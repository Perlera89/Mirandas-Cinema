const fila2 = document.querySelector('.carousel2');
const pelicula2 = document.querySelectorAll('.pelicula2');

const flechaIzquierda2 = document.getElementById('flecha_izquierda2');
const flechaDerecha2 = document.getElementById('flecha_derecha2');

/*-------flecha derecha------*/
flechaDerecha2.addEventListener('click', () => {
    fila2.scrollLeft += fila2.offsetWidth;

    const indicadorActivo = document.querySelector('.indicadores2 .activo');
    //preguntando si hay un elemento a la derecha
    if (indicadorActivo.nextSibling) {
        indicadorActivo.nextSibling.classList.add('activo');
        indicadorActivo.classList.remove('activo');
    }
});

flechaIzquierda2.addEventListener('click', () => {

    fila2.scrollLeft -= fila2.offsetWidth;
    const indicadorActivo = document.querySelector('.indicadores2 .activo');
    //preguntando si hay un elemento a la derecha
    if (indicadorActivo.previousSibling) {
        indicadorActivo.previousSibling.classList.add('activo');
        indicadorActivo.classList.remove('activo');
    }
});

/*------paginacion------*/
const numeroPaginas2 = Math.ceil(pelicula2.length / 5);
for (let i = 0; i < numeroPaginas2; i++) {
    const indicador = document.createElement('button');

    if (i === 0) {
        indicador.classList.add('activo');
    }

    document.querySelector('.indicadores2').appendChild(indicador);
    indicador.addEventListener('click', (e) => {
        fila2.scrollLeft += i * fila2.offsetWidth;

        document.querySelector('.indicadores2 .activo').classList.remove('activo');
        /*el botton clickeado*/
        e.target.classList.add('activo');
    });
}

function Desactivar() {
    const numeroPeliculas2 = Math.ceil(pelicula2.length);
    /*----carousel 2----*/
    if (numeroPeliculas2 <= 5) {
        flechaIzquierda2.classList.add('desactivar');
        flechaDerecha2.classList.add('desactivar');
        document.querySelector('.indicadores2').classList.add('desactivar');
    }
    else {
        flechaIzquierda2.classList.remove('desactivar');
        flechaDerecha2.classList.remove('desactivar');
        document.querySelector('.indicadores2').classList.remove('desactivar');
    }
}
Desactivar();
//hover

pelicula2.forEach((pelicula2) => {
    pelicula2.addEventListener('mouseenter', (e) => {
        const elemento = e.currentTarget;
        setTimeout(() => {
            for (var i = 0; i < pelicula2; i++) {
                pelicula2 => pelicula2.classList.remove('hover');
            }

            elemento.classList.add('hover');
        }, 300);
    });
});

fila2.addEventListener('mouseleave', () => {
    pelicula2.forEach(pelicula2 => pelicula2.classList.remove('hover'));

});