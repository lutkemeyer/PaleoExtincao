using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositorioConteudo{

    private List<Dinossauro> dinossauros = new List<Dinossauro>();

    public RepositorioConteudo(Sprite[] sprites) {

        addDinossauro(sprites[0], 
            "Saurópodes", 
            "Braquiossauro", 
            "Os saurópodes (do latim científico Sauropoda) foram um dos dois grandes grupos de dinossauros saurísquios ou dinossauros com " +
            "bacia de réptil. Os seus corpos eram enormes, com um pescoço muito comprido que terminava em uma cabeça muito pequena. A cauda" +
            ", também muito comprida, junto com uma grande unha que a maioria dos saurópodes possuíam na pata dianteira, eram suas únicas " +
            "armas de defesa, além de seu tamanho.");

        addDinossauro(sprites[1], 
            "Carnosauria",
            "Concavenator corcovatus", 
            "Carnosauria (que significa \"lagartos carnívoros\") é uma micro-ordem de dinossauros terópodes, característicos do período Cretáceo, " +
            "mas presentes também no Triássico e no Jurássico em menor número. Os carnossauros, como são chamados os dinossauros pertencentes " +
            "à ordem carnosauria, viveram principalmente na América do Norte e na América do Sul. Os carnossauros se alimentavam de carne de " +
            "outros dinossauros, caracterizando assim uma alimentação carnívora típica dos " +
            "dinossauros terópodes.");

        addDinossauro(sprites[2], 
            "Tyrannosauridae", 
            "Dilong",
            "Tyrannosauridae é uma família de dinossauros terópodes tetanúreos, característicos do Cretáceo superior. O grupo inclui os " +
            "maiores predadores carnívoros que já existiram sobre a Terra, entre eles o famoso Tyrannosaurus rex. Uma característica " +
            "distintiva do grupo são os membros anteriores, minúsculos por relação ao resto do corpo e demasiado pequenos para desempenharem " +
            "uma função activa. Os tiranossaurídeos mediam, conforme o tipo, entre 8 a 15 metros de comprimento e pesavam entre 2 a 8 toneladas." +
            "No entanto, a espécie Dilong paradoxus tinha apenas 1,6 metro de comprimento e tinha penas.");

        addDinossauro(sprites[3], 
            "Compsognatídeos",
            "Sinosauropteryx",
            "Compsognato (nome científico: Compsognathus longipes) é a única espécie conhecida do gênero extinto Compsognathus de dinossauros " +
            "terópodes compsognatídeos, que viveram no fim do período Jurássico há aproximadamente 150 milhões de anos, na idade do Tithoniano, " +
            "onde hoje é a Europa.");

        addDinossauro(sprites[4], 
            "Therizinossauro", 
            "Dinossauro 5", 
            "bla bla bla");

        addDinossauro(sprites[5], 
            "Alvarezsaurídeos", 
            "Dinossauro 6",
            "bla bla bla");

        addDinossauro(sprites[6], 
            "Oviraptorosauria", 
            "Dinossauro 7",
            "bla bla bla");

        addDinossauro(sprites[7], 
            "Oviraptorosauria", 
            "Dinossauro 8",
            "bla bla bla");

        addDinossauro(sprites[8], 
            "Tradentids", 
            "Dinossauro 9",
            "bla bla bla");

        addDinossauro(sprites[9], 
            "Dromzeosaurs", 
            "Dinossauro 10",
            "bla bla bla");

        addDinossauro(sprites[10], 
            "Dromzeosaurs", 
            "Dinossauro 11",
            "bla bla bla");

        addDinossauro(sprites[11], 
            "Sacnoriopterygids", 
            "Dinossauro 12",
            "bla bla bla");

        addDinossauro(sprites[12], 
            "Aves", 
            "Dinossauro 13",
            "bla bla bla");

        addDinossauro(sprites[13], 
            "Aves", 
            "Dinossauro 14",
            "bla bla bla");

        addDinossauro(sprites[14], 
            "Aves", 
            "Dinossauro 15",
            "bla bla bla");

        addDinossauro(sprites[15], 
            "Aves Modernas", 
            "Dinossauro 16",
            "bla bla bla");
    }
    public void addDinossauro(Sprite spr, string familia, string nome, string descricao) {
        dinossauros.Add(new Dinossauro(spr,familia,nome,descricao));
    }
    public Dinossauro get(int index) {
        return dinossauros[index];
    }
}
