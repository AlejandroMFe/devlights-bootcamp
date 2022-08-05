export class Activity {
    title!: string;
    description!: string;
    urlImage: string;

    constructor(title: string, description: string, urlImage: string) {
        this.title = title;
        this.description = description;
        this.urlImage = urlImage;
    }

    public static getActivities(): Activity[] {
        return [
            new Activity('Musculacion', 'Esculpí tus músculos con entrenamientos personalizados', '../../../assets/musculacion1.jpg'),
            new Activity('G.A.P.', 'Clase intensiva para trabajar glúteos abdomen y piernas', '../../../assets/gap.jpg'),
            new Activity('Pilates', 'Fotalece y gana flexibilidad para tus músculos', '../../../assets/pilates.jpg'),
            new Activity('Funcional', 'Disfruta de un entrenamiento intensivo, divertido y en grupo', '../../../assets/funcional.jpg'),
            new Activity('Indoor Bike', 'Supera tus límites ampliando tus capacidades', '../../../assets/indoorbike.jpg'),
        ];
    }

    public static getStudentsActivities(): any[] {
        return [
            {
                name: 'Juan Pablo',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "G.A.P."
            }
            ,
            {
                name: 'Sebastian',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "G.A.P."
            },
            {
                name: 'Juan Pablo',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "G.A.P."
            }
            ,
            {
                name: 'Sebastian',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "G.A.P."
            },
            {
                name: 'Juan Pablo',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "G.A.P."
            }
            ,
            {
                name: 'Sebastian',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "G.A.P."
            },
            {
                name: 'Steffanie',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Pilates'
            },
            {
                name: 'Juana',
                lastname: 'Sanchez',
                age: '20',
                email: 'applied@example.com',
                class: 'Pilates'
            }
            ,
            {
                name: 'Leandro',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Pilates'
            }
            ,
            {
                name: 'Julian',
                lastname: 'Perezas',
                age: '20',
                email: 'applied@example.com',
                class: 'Pilates'
            },

            {
                name: 'Julian',
                lastname: 'Perezas',
                age: '20',
                email: 'applied@example.com',
                class: 'Pilates'
            },

            {
                name: 'Julian',
                lastname: 'Perezas',
                age: '20',
                email: 'applied@example.com',
                class: 'Pilates'
            }
            ,
            {
                name: 'Ana',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Pilates'
            },
            {
                name: 'Juan',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "Indoor Bike"
            },
            {
                name: 'Pedro',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "Indoor Bike"
            },
            {
                name: 'Juana',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "Indoor Bike"
            }
            ,
            {
                name: 'Julian',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "Indoor Bike"
            },
            {
                name: 'Pedro',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "Indoor Bike"
            },
            {
                name: 'Juana',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "Indoor Bike"
            }
            ,
            {
                name: 'Julian',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "Indoor Bike"
            },
            {
                name: 'Pedro',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "Indoor Bike"
            },
            {
                name: 'Juana',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "Indoor Bike"
            }
            ,
            {
                name: 'Julian',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: "Indoor Bike"
            },
            {
                name: 'JMarilyn',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Musculación'
            }
            ,
            {
                name: 'Ryan',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Musculación'
            },
            {
                name: 'JMarilyn',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Musculación'
            }
            ,
            {
                name: 'Ryan',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Musculación'
            },
            {
                name: 'JMarilyn',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Musculación'
            }
            ,
            {
                name: 'Ryan',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Musculación'
            },
            {
                name: 'JMarilyn',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Musculación'
            }
            ,
            {
                name: 'Ryan',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Musculación'
            },
            {
                name: 'JMarilyn',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Musculación'
            }
            ,
            {
                name: 'Ryan',
                lastname: 'Perez',
                age: '20',
                email: 'applied@example.com',
                class: 'Musculación'
            }


        ];
    }
}