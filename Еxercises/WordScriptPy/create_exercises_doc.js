const fs = require('fs');
const { Document, Packer, Paragraph, TextRun } = require('docx');

// Създаване на нов документ
const doc = new Document({
    sections: [{
        properties: {},
        children: [
            new Paragraph({
                children: [
                    new TextRun({
                        text: "WHIZ ACADEMY",
                        bold: true,
                        size: 48
                    })
                ],
            }),
            new Paragraph({
                children: [
                    new TextRun({
                        text: "Задачи: Условни проверки",
                        bold: true,
                        size: 32
                    })
                ],
            }),

            // Задача 1
            new Paragraph({
                children: [
                    new TextRun({
                        text: "1. Задача: Принтиране на текст до команда \"Stop\"",
                        bold: true,
                        size: 24
                    })
                ],
            }),
            new Paragraph("Напишете програма, която чете текстови вход от конзолата и го принтира на изхода, докато не получи команда \"Stop\". Когато програмата прочете \"Stop\", тя трябва да прекъсне цикъла и да приключи."),
            new Paragraph({
                children: [
                    new TextRun({
                        text: "Вход",
                        bold: true,
                        size: 20
                    })
                ],
            }),
            new Paragraph("Програмата приема произволен брой редове текст, които ще бъдат въведени от потребителя."),
            new Paragraph({
                children: [
                    new TextRun({
                        text: "Изход",
                        bold: true,
                        size: 20
                    })
                ],
            }),
            new Paragraph("Програмата принтира всеки въведен ред текст, докато не срещне командата \"Stop\". Командата \"Stop\" не трябва да бъде принтирана."),
            new Paragraph({
                children: [
                    new TextRun({
                        text: "Пример:",
                        bold: true,
                        size: 20
                    })
                ],
            }),
            new Paragraph("Вход:\n• FirstLine\n• SecondLine\n• ThirdLine\nStop"),
            new Paragraph("Изход:\n• FirstLine\n• SecondLine\n• ThirdLine"),

            // Задача 2
            new Paragraph({
                children: [
                    new TextRun({
                        text: "2. Проверка на парола и поздрав",
                        bold: true,
                        size: 24
                    })
                ],
            }),
            new Paragraph("Напишете програма, която първоначално прочита име и парола на потребителски профил. След това чете парола за вход."),
            new Paragraph("• При въвеждане на грешна парола: потребителят да се подкани да въведе нова парола."),
            new Paragraph("• При въвеждане на правилна парола: отпечатваме \"Welcome {username}!\"."),
            new Paragraph({
                children: [
                    new TextRun({
                        text: "Вход:",
                        bold: true,
                        size: 20
                    })
                ],
            }),
            new Paragraph("Програмата първо приема две линии:\n• Потребителско име (username).\n• Парола (password).\nСлед това приема пароли за вход, докато не се въведе правилната парола."),
            new Paragraph({
                children: [
                    new TextRun({
                        text: "Изход:",
                        bold: true,
                        size: 20
                    })
                ],
            }),
            new Paragraph("Програмата отпечатва \"Welcome {username}!\" при въвеждане на правилна парола."),
            new Paragraph({
                children: [
                    new TextRun({
                        text: "Пример:",
                        bold: true,
                        size: 20
                    })
                ],
            }),
            new Paragraph("Вход:\n• Gosho\n• secret\n• secret"),
            new Paragraph("Изход:\n• Welcome Gosho!"),

            // Задача 3
            new Paragraph({
                children: [
                    new TextRun({
                        text: "3. Информация за скоростта",
                        bold: true,
                        size: 24
                    })
                ],
            }),
            new Paragraph("Да се напише програма, която чете скорост (реално число), въведена от потребителя и отпечатва информация за скоростта."),
            new Paragraph("• При скорост до 10 (включително) отпечатайте \"slow\""),
            new Paragraph("• При скорост над 10 и до 50 (включително) отпечатайте \"average\""),
            new Paragraph("• При скорост над 50 и до 150 (включително) отпечатайте \"fast\""),
            new Paragraph("• При скорост над 150 и до 1000 (включително) отпечатайте \"ultra fast\""),
            new Paragraph("• При по-висока скорост отпечатайте \"extremely fast\""),

            // Задача 4
            new Paragraph({
                children: [
                    new TextRun({
                        text: "4. Почивен или работен ден",
                        bold: true,
                        size: 24
                    })
                ],
            }),
            new Paragraph("Напишете програма която, чете ден от седмицата (текст), на английски език - въведен от потребителя.Ако денят е работен отпечатва на конзолата - \"Working day\", ако е почивен - \"Weekend\". Ако се въведе текст различен от ден от седмицата да се отпечата - \"Error\"."),

            // Задача 5
            new Paragraph({
                children: [
                    new TextRun({
                        text: "5. Билет за кино",
                        bold: true,
                        size: 24
                    })
                ],
            }),
            new Paragraph("Да се напише програма която чете ден от седмицата (текст) – въведен от потребителя и принтира на конзолата цената на билет за кино според деня от седмицата:"),
            new Paragraph(`
Monday    Tuesday    Wednesday    Thursday    Friday    Saturday    Sunday
12        12         14           14          12        16         16
`),
            new Paragraph({
                children: [
                    new TextRun({
                        text: "Примерен вход и изход",
                        bold: true,
                        size: 20
                    })
                ],
            }),
            new Paragraph(`
вход    изход        вход    изход        вход    изход
Monday  12           Friday  12           Sunday  16
`),

            // Задача 6
            new Paragraph({
                children: [
                    new TextRun({
                        text: "6. Квартално магазинче",
                        bold: true,
                        size: 24
                    })
                ],
            }),
            new Paragraph("Предприемчив българин отваря квартални магазинчета в няколко града и продава на различни цени според града:"),
            new Paragraph(`
град / продукт    coffee    water    beer    sweets    peanuts
Sofia             0.50      0.80     1.20    1.45      1.60
Plovdiv           0.40      0.70     1.15    1.30      1.50
Varna             0.45      0.70     1.10    1.35      1.55
`),
            new Paragraph("Напишете програма, която чете продукт (низ), град (низ) и количество (десетично число), въведени от потребителя, и пресмята и отпечатва колко струва съответното количество от избрания продукт в посочения град."),
            new Paragraph({
                children: [
                    new TextRun({
                        text: "Примерен вход и изход",
                        bold: true,
                        size: 20
                    })
                ],
            }),
            new Paragraph(`
вход        изход        вход        изход        вход        изход        вход        изход        вход        изход
coffee      Varna 2      0.9         peanuts      Plovdiv 1   1.5          beer        Sofia 6      7.2         water      Plovdiv 3   2.1         sweets      Sofia 2.23 3.2335
`),
        ],
    }],
});

// Запазване на документа
Packer.toBuffer(doc).then((buffer) => {
    fs.writeFileSync("whiz_academy_exercises.docx", buffer);
    console.log("Document created successfully");
});
