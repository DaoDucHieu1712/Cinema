
const create = document.querySelector('.movie-add');
create.addEventListener('click', (e) => {
    const create_from = document.querySelector('.create');
    create_from.classList.add('create-show');
})

const close_create = document.querySelector('.create-close');
close_create.addEventListener('click', (e) => {
    const create_from = document.querySelector('.create');
    create_from.classList.remove('create-show');
}
)

const close_update = document.querySelector('.update-close');
close_update.addEventListener('click', (e) => {
    const create_from = document.querySelector('.update');
    create_from.classList.remove('update-show');
});

const delete_movie = document.querySelector('#delete-movie');

const btn_delete = document.querySelector('#delete-movie');
function delete_Movie(id) {

    const template = `<div class="delete">
<div class="delete-model">
    <div class="delete-model-left">
        <h2 class="delete-heading">Update Movies</h2>
    </div>
    <div class="delete-model-right">
        <i class="fas fa-times delete-close"></i>
    </div>
</div>
<div class="delete-content">
    <a id="delete-cancel" class="delete-btn">Cancel</a>
    <a href="/Movie/Delete?id=${id}" class="delete-btn">Delete</a>
</div>
</div>`;
    document.body.insertAdjacentHTML('beforeend', template);
    btn_delete.setAttribute('disabled', '');
}

document.addEventListener('click', (e) => {
    const tpl_deleteles = document.querySelector('.delete');
    const close_deleteles = document.querySelector('.delete-close');
    const cancelles = document.querySelector('#delete-cancel');
    if (e.target.matches('.delete-close') || e.target.matches('#delete-cancel')) {
        document.body.removeChild(tpl_deleteles);
    }
});

