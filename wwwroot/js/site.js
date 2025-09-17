// Fleet Command Center interactions
// ---------------------------------
(() => {
    document.addEventListener('DOMContentLoaded', () => {
        const sidebar = document.querySelector('.app-sidebar');
        const toggleButton = document.querySelector('[data-bs-target="#sidebarOffcanvas"]');

        if (sidebar && toggleButton) {
            toggleButton.addEventListener('click', () => {
                sidebar.classList.toggle('sidebar-open');
            });
        }
    });
})();
