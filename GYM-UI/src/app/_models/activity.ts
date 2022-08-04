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
}