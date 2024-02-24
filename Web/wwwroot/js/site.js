// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//Layout Specific
function loadTheme(){
    'use strict'

    const getStoredTheme = () => localStorage.getItem('theme')
    //const setStoredTheme = theme => localStorage.setItem('theme', theme)

    const getPreferredTheme = () => {
        const storedTheme = getStoredTheme()
        if (storedTheme) {
            return storedTheme
        }

        return window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light'
    }

    const setTheme = theme => {
        if (theme === 'auto') {
            document.documentElement.setAttribute('data-bs-theme', (window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light'))
        } else {
            document.documentElement.setAttribute('data-bs-theme', theme)
        }
    }

    setTheme(getPreferredTheme())

    var activeThemeIcon = (getStoredTheme() === 'dark') ? "bi bi-moon-fill small" : "bi bi-brightness-high small";
    $("#currentThemeIcon").attr('class', activeThemeIcon);
};


function updateSiteTheme(theme) {
    localStorage.setItem('theme', theme)
    loadTheme();
};

document.addEventListener("DOMContentLoaded", function () {
    // Handler when the DOM is fully loaded
    loadTheme();
    $('#setThemeLight').on('click', function () {
        updateSiteTheme('light');
    });
    $('#setThemeDark').on('click', function () {
        updateSiteTheme('dark');
    });
});