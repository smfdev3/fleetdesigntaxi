// Fleet Command Center interactions
// ---------------------------------
(() => {
    document.addEventListener('DOMContentLoaded', () => {
        const sidebar = document.getElementById('sidebarPanel');
        const toggleButton = document.querySelector('[data-sidebar-toggle]');

        if (sidebar && toggleButton) {
            toggleButton.addEventListener('click', () => {
                const isOpen = sidebar.classList.toggle('sidebar-open');
                toggleButton.setAttribute('aria-expanded', isOpen.toString());
            });

            window.addEventListener('resize', () => {
                if (window.innerWidth >= 992 && sidebar.classList.contains('sidebar-open')) {
                    sidebar.classList.remove('sidebar-open');
                    toggleButton.setAttribute('aria-expanded', 'false');
                }
            });
        }
    });
})();
