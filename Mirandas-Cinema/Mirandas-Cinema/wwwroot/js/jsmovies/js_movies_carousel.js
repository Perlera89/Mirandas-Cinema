const fila = document.querySelector('.carousel1');
const pelicula = document.querySelectorAll('.pelicula1');

const flechaIzquierda = document.getElementById('flecha_izquierda1');
const flechaDerecha = document.getElementById('flecha_derecha1');

/*-------flecha derecha------*/
flechaDerecha.addEventListener('click', () => {
    fila.scrollLeft += fila.offsetWidth;

    const indicadorActivo = document.querySelector('.indicadores1 .activo');
    //preguntando si hay un elemento a la derecha
    if (indicadorActivo.nextSibling) {
        indicadorActivo.nextSibling.classList.add('activo');
        indicadorActivo.classList.remove('activo');
    }
});

flechaIzquierda.addEventListener('click', () => {

    fila.scrollLeft -= fila.offsetWidth;
    const indicadorActivo = document.querySelector('.indicadores1 .activo');
    //preguntando si hay un elemento a la derecha
    if (indicadorActivo.previousSibling != false) {
        indicadorActivo.previousSibling.classList.add('activo');
        indicadorActivo.classList.remove('activo');
    }
});

/*------paginacion------*/
const numeroPaginas = Math.ceil(pelicula.length / 5);
for (let i = 0; i < numeroPaginas; i++) {
    const indicador = document.createElement('button');

    if (i === 0) {
        indicador.classList.add('activo');
    }

    document.querySelector('.indicadores1').appendChild(indicador);
    indicador.addEventListener('click', (e) => {
        fila.scrollLeft += i * fila.offsetWidth;

        document.querySelector('.indicadores1 .activo').classList.remove('activo');
        /*el botton clickeado*/
        e.target.classList.add('activo');
    });
}


function Desactivar() {
    const numeroPeliculas = Math.ceil(pelicula.length);
    /*----carousel 1----*/
    if (numeroPeliculas <= 5) {
        flechaIzquierda.classList.add('desactivar');
        flechaDerecha.classList.add('desactivar');
        document.querySelector('.indicadores1').classList.add('desactivar');
    }
    else {
        flechaIzquierda.classList.remove('desactivar');
        flechaDerecha.classList.remove('desactivar');
        document.querySelector('.indicadores1').classList.remove('desactivar');
    }
}
Desactivar();
//hover

pelicula.forEach((pelicula) => {
    pelicula.addEventListener('mouseenter', (e) => {
        const elemento = e.currentTarget;
        setTimeout(() => {
            for (var i = 0; i < pelicula; i++) {
                pelicula => pelicula.classList.remove('hover');
            }

            elemento.classList.add('hover');
        }, 300);
    });
});

fila.addEventListener('mouseleave', () => {
    pelicula.forEach(pelicula => pelicula.classList.remove('hover'));

});