// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.sr = ScrollReveal();
let tareasAnimacion = {
    duration: 1000,
    origin: 'rigth',
    distance: '500px',
    reset: false
}

sr.reveal('.containerC', {
    duration: 2000,
    origin: 'left',
    distance: '100px',
    reset: true
})
sr.reveal('.img-ESPE', {
    duration: 2000,
    origin: 'top',
    distance: '100px',
    reset: true
})
sr.reveal('.h1', {
    duration: 3000,
    origin: 'left',
    distance: '500px',
    reset: false
})
sr.reveal('.card', {
    duration: 1000,
    origin: 'left',
    distance: '100px',
    reset: false
})
sr.reveal('.tabla', {
    duration: 1000,
    origin: 'bottom',
    distance: '100px',
    reset: false
})

sr.reveal('.CrearTarea', tareasAnimacion)
sr.reveal('.EliminarTarea', tareasAnimacion)
sr.reveal('.EditTarea', tareasAnimacion)
sr.reveal('.CrearEstudiante', tareasAnimacion)
sr.reveal('.EditEstudiante', tareasAnimacion)
sr.reveal('.DetalleEstudiante', tareasAnimacion)
sr.reveal('.EliminarEstudiante', tareasAnimacion)



