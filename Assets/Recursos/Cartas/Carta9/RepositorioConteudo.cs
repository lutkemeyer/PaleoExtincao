using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositorioConteudo{

    private List<GeneroDinossauro> generosDinossauros = new List<GeneroDinossauro>();

    public RepositorioConteudo(Sprite[] sprites) {

        addGeneroDinossauro(sprites[0], 
            "Saurópodes", 
            "Braquiossauro",
            "Os saurópodes (do latim Sauropoda) foram um dos dois grandes grupos de dinossauros saurísquios. Os seus corpos eram enormes, " +
            "com um pescoço muito comprido que terminava em uma cabeça muito pequena. O Braquiossauro cujo nome significa, dado os seus " +
            "membros anteriores (\"braços\") serem maiores que os posteriores, era um gênero de dinossauros saurópode que viveu durante o" +
            " fim do período Jurássico. Este animal tinha entre 18 e 20 metros de altura e cerca de 25 metros de comprimento. Estima-se que " +
            "o peso do animal girava em torno de 50 toneladas.");

        addGeneroDinossauro(sprites[1], 
            "Carnosauria",
            "Concavenator",
            "Carnosauria (que significa \"lagartos carnívoros\") é uma micro-ordem de dinossauros terópodes, característicos do " +
            "período Cretáceo, Triássico e Jurássico. Viveram principalmente na América do Norte e na América do Sul. O Concavenator " +
            "corcovatus é uma espécie de dinossauro terópode que contava com cerca de 4 m de comprimento e que teria vivido há cerca " +
            "de 130 milhões de anos. Esse gênero possui duas características notáveis. A primeira é a presença de uma barbatana óssea " +
            "similar a uma corcova ou barbatana de tubarão, já a segunda é a presença de bulbos foliculares similares a primeira fase " +
            "de desenvolvimento das penas nos membros superiores.");

        addGeneroDinossauro(sprites[2],
            "Tyrannosauroidea", 
            "Dilong",
            "Tyrannosauroidea é uma superfamília de dinossauros terópodes coelurossaurianos, que viveram desde o período " +
            "Jurássico até o Cretáceo, no que hoje é a Ásia, Europa, América do Norte e América do Sul. Dilong ou \"Dragão imperador\" " +
            "foi um gênero de Dinossauro Tiranossaurídeo que viveu na China no início do Cretáceo (há aproximadamente 130 milhões de anos). " +
            "O mais surpreendente deste gênero é que apresentava uma cobertura corporal de protoplumas.");

        addGeneroDinossauro(sprites[3],
            "Compsognathidae",
            "Sinosauropteryx",
            "Compsognathidae é uma família de dinossauros terópodes coelurossaurianos. Eram pequenos carnívoros, geralmente conservadores, " +
            "oriundos dos períodos Jurássico e Cretáceo. O Sinosauropteryx é um gênero dessa família que possuía penas, vivendo entre 124,6 " +
            "e 122 milhões de anos atrás. Atingia 1,07 metro de comprimento e 1 kg de massa. Sua cauda extremamente longa possuía 64 vértebras. " +
            "Foi descoberto na Formação Yixian, na província chinesa de Liaoning e é atualmente conhecido por vários esqueletos completos, ovos e penas.");

        addGeneroDinossauro(sprites[4],
            "Therizinosauridae",
            "Beipiaosaurus",
            "Therizinosauridae é uma família de dinossauros terópodes herbívoros ou onívoros avançados. Os fósseis existentes foram recuperados " +
            "de depósitos do Cretáceo Médio-Superior nos Estados Unidos, China e Mongólia. Os Beipiaossauros, que traduz como \"lagarto de Beipiao\" " +
            "foram encontrados na Província de Liaoning, na China e foram datados ao período Cretáceo, há aproximadamente 125 milhões de anos.");

        addGeneroDinossauro(sprites[5],
            "Alvarezsauridae",
            "Shuvuuia",
            "Alvarezsauridae é uma família de pequenos dinossauros de pernas longas. Os Alvarezsaurídeos eram altamente especializados, tinham " +
            "membros anteriores minúsculos, mas robustos, com mãos compactas, semelhantes a pássaros. O Shuvuuia é um gênero de dinossauros " +
            "terópodes emplumados que viveu no período Cretáceo Superior, que é hoje a Mongólia. Se caracterizam por curtos mas poderosos braços " +
            "especializados para cavar. Era um animal pequeno e leve, tinha 60 cm de comprimento, sendo um dos menores dinossauros conhecidos.");

        addGeneroDinossauro(sprites[6],
            "Oviraptoridae",
            "Protarchaeopteryx",
            "Oviraptoridae é um grupo de dinossauros maniraptoranos herbívoros e omnívoros extintos aparentados das aves. Caracterizam-se pelos " +
            "bicos sem dentes e semelhantes aos de papagaios e, em alguns casos, cristas sofisticadas. Eram geralmente pequenos, medindo entre " +
            "um e dois metros de comprimento na maioria dos casos. Protarchaeopteryx robusta é uma espécie de dinossauro terópodo ovirraptorossauriano " +
            "do tamanho de um peru, que viveu no Cretáceo inferior (há aproximadamente 124 milhões de anos, no Barremiano), onde que hoje é a China. " +
            "É a única espécie descrita para o gênero Protarchaeopteryx.");

        addGeneroDinossauro(sprites[7],
            "Oviraptoridae",
            "Caudipteryx",
            "Oviraptoridae é um grupo de dinossauros maniraptoranos herbívoros e omnívoros extintos aparentados das aves. Caracterizam-se pelos " +
            "bicos sem dentes e semelhantes aos de papagaios e, em alguns casos, cristas sofisticadas. Eram geralmente pequenos, medindo entre " +
            "um e dois metros de comprimento na maioria dos casos. O Caudipteryx era uma criatura de pernas longas e tamanho semelhante ao de " +
            "um peru, com um bico semelhante ao das aves, penas e uma cauda curta, mas com os dentes e ossos semelhantes aos de um dinossauro " +
            "terópode não-aviário. Viveu no início do Cretáceo, não muito tempo depois do aparecimento da primeira ave conhecida.");

        addGeneroDinossauro(sprites[8],
            "Troodontidae",
            "Anchiornis",
            "Troodontidae é uma família de dinossauros terópodes de pequeno porte, considerado o grupo de dinossauros mais inteligente. " +
            "Apresentavam órbita ocular grande, indicando hábitos noturnos, e a maioria dos dinossauros desse grupo caçavam mamíferos e pequenos " +
            "lagartos à noite, quando estes saíam para se alimentar ou estavam quase inativos, respectivamente. Anchiornis huxleyi é uma espécie " +
            "de dinossauro terópode do período Cretáceo Inferior que viveu na China. Anchiornis significa \"próximo a ave\", e os seus proponentes " +
            "referem que este género preenche um buraco importante na compreensão da evolução do plano morfológico das aves a partir dos dinossauros.");

        addGeneroDinossauro(sprites[9],
            "Dromaeosauridae",
            "Sinornithosaurus",
            "Dromaeosauridae é uma família de dinossauros terópodes com penas. Eles eram geralmente pequenos e médios carnívoros de penas que " +
            "floresceram no período cretáceo. O Sinornithosaurus, que significa 'lagarto-pássaro chinês', é um gênero de dinossauro que possuía " +
            "penas e viveu durante o Cretáceo Inferior, no que é hoje a China. Com um comprimento de cerca de 90 a 120 centímetros três quilogramas, " +
            "o Sinornithosaurus foi o quinto gênero de dinossauro de penas não aviário descoberto em 1999, datado de 124,5 milhões de anos atrás.");

        addGeneroDinossauro(sprites[10],
            "Dromaeosauridae",
            "Microraptor",
            "Dromaeosauridae é uma família de dinossauros terópodes com penas. Eles eram geralmente pequenos e médios carnívoros de penas que " +
            "floresceram no período cretáceo. O Microraptor (do latim \"pequeno ladrão caçador\") é um gênero de dinossauro carnívoro, emplumado " +
            "e semibípede que viveu na primeira metade do período Cretáceo. Media em torno de 30 centímetros de altura, 50 a 70 centímetros de " +
            "comprimento e pesava de 1 a 4 quilogramas, sendo um dos menores dinossauros que já viveram na Terra.");

        addGeneroDinossauro(sprites[11],
            "Scansoriopterygidae",
            "Epidexipteryx",
            "Scansoriopterygidae é uma família de dinossauros do clado Paraves. Ocorreu na Ásia no período Jurássico Médio a Superior. O Epidexipteryx " +
            "é um gênero de dinossauro descoberta na China por Fucheng Zhang e mais cientistas. Caracterizava-se por ter o tamanho de um pombo e longas " +
            "penas, porém não conseguia voar. Representa o exemplo mais antigo conhecido de penas ornamentais no registro fóssil. Viveu a cerca de 160 " +
            "ou 168 milhões de anos atrás.");

        addGeneroDinossauro(sprites[12], 
            "Aves",
            "Archaeopteryx",
            "Archaeopteryx lithographica é uma espécie fóssil de dinossauro terópode emplumado. É a única espécie reconhecida do gênero Archaeopteryx. " +
            "Algumas vezes é referido pela palavra alemã Urvogel, que significa \"primeira ave\" ou \"ave original\". Viveu durante o período Jurássico em " +
            "torno de 150-148 milhões de anos atrás, no que agora é do sul da Alemanha.");

        addGeneroDinossauro(sprites[13], 
            "Aves",
            "Jeholornis",
            "Jeholornis é um gênero de aves primitivas que viveram entre cerca de 122 e 120 milhões de anos atrás, durante o início do período cretáceo " +
            "na China. Diversos fósseis, pertencentes às espécies Jeholornis prima e Jeholornis palmapenis, foram encontrados preservados na China, na " +
            "Floresta Jehol, daí o nome do gênero.");

        addGeneroDinossauro(sprites[14], 
            "Aves",
            "Confuciusornis",
            "Confuciusornis é um gênero fóssil de aves primitivas, do tamanho de um corvo, que habitou a Terra entre 125 e 140 milhões de anos atrás, " +
            "sendo seus fósseis encontrados na China. Da mesma forma que as aves atuais, o Confuciusornis possuía um bico sem dentes. No entanto, " +
            "parentes muito próximos das aves modernas, tais como Hesperornis e Ichthyornis, possuíam dentes, o que indica que a perda dos mesmos " +
            "ocorreu de forma convergente entre os Confuciusornis e as aves que habitam hoje o nosso planeta. É a mais antiga ave conhecida a possuir bico.");

        addGeneroDinossauro(sprites[15], 
            "Aves",
            "Neornithes",
            "A subclasse Neornithes ou aves modernas é um clado constituído por todas as aves que vivem na época recente e atual, e que inclui " +
            "mais de 10 milhares de espécies. As aves modernas apresentam notáveis características que as diferenciam do resto dos vertebrados, " +
            "sendo talvez a mais notória que a sua pele está na sua maioria coberta de penas, e que as extremidades anteriores estão transformadas " +
            "em asas. Outras características que distinguem as aves são a presença de um bico sem dentes, um coração com quatro câmaras, um metabolismo " +
            "alto e ossos ocos (que favorecem o voo).");
    }
    public void addGeneroDinossauro(Sprite spr, string familia, string nome, string descricao) {
        generosDinossauros.Add(new GeneroDinossauro(spr,familia,nome,descricao));
    }
    public GeneroDinossauro get(int index) {
        return generosDinossauros[index];
    }
}
