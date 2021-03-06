function enableFramework(elm) {
    elm.find('.add-option-empty').each(function () {
        let selectElm = jQuery(this);
        selectElm.prepend(new Option("", ""));

        if (selectElm.hasClass('chosen')) {
            elm.trigger('chosen:update');
        }
    });
}

function enableChosen(elm) {
    let noResultsText = elm.data('no-results-text') ?? 'No results';
    let placeholderTextSingle = elm.data('placeholder-text-single') ?? '';
    let allowSingleDeselect = elm.data('allow-single-deselect') ?? true;

    elm.chosen({
        allow_single_deselect: allowSingleDeselect,
        no_results_text: noResultsText,
        placeholder_text_single: placeholderTextSingle
    });
}

jQuery(document).ready(function () {

    let body = jQuery('body');

    enableFramework(body);

    body.find('.chosen').each(function () {
        enableChosen(jQuery(this));
    });

    particlesJS("particles-js", {
        "particles": {
            "number": {
                "value": 80,
                "density": {
                    "enable": true,
                    "value_area": 800
                }
            },
            "color": {
                "value": "#FF0000"
            },
            "shape": {
                "type": "circle",
                "stroke": {
                    "width": 1,
                    "color": "#FF652F"
                },
                "polygon": {
                    "nb_sides": 5
                },
                "image": {
                    "src": "img/github.svg",
                    "width": 100,
                    "height": 100
                }
            },
            "opacity": {
                "value": 0.5,
                "random": false,
                "anim": {
                    "enable": false,
                    "speed": 1,
                    "opacity_min": 0.1,
                    "sync": false
                }
            },
            "size": {
                "value": 3,
                "random": true,
                "anim": {
                    "enable": false,
                    "speed": 40,
                    "size_min": 0.1,
                    "sync": false
                }
            },
            "line_linked": {
                "enable": true,
                "distance": 150,
                "color": "#FF652F",
                "opacity": 0.4,
                "width": 1
            },
            "move": {
                "enable": true,
                "speed": 6,
                "direction": "none",
                "random": false,
                "straight": false,
                "out_mode": "out",
                "bounce": false,
                "attract": {
                    "enable": false,
                    "rotateX": 600,
                    "rotateY": 1200
                }
            }
        },
        "interactivity": {
            "detect_on": "canvas",
            "events": {
                "onhover": {
                    "enable": false,
                    //"mode": "grab"
                },
                "onclick": {
                    "enable": true,
                    "mode": "push"
                },
                "resize": true
            },
            "modes": {
                "grab": {
                    "distance": 140,
                    "line_linked": {
                        "opacity": 1
                    }
                },
                "bubble": {
                    "distance": 400,
                    "size": 40,
                    "duration": 2,
                    "opacity": 8,
                    "speed": 3
                },
                "repulse": {
                    "distance": 200,
                    "duration": 0.4
                },
                "push": {
                    "particles_nb": 4
                },
                "remove": {
                    "particles_nb": 2
                }
            }
        },
        "retina_detect": true
    });

//    jQuery('[data-tooltip=]').tooltip();
});