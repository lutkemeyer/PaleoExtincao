using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositorioConteudo{

    private List<FamiliaDinossauro> familiasDinossauro;
    
    public RepositorioConteudo(Sprite[] sprites) {
        familiasDinossauro = new List<FamiliaDinossauro>();
        string txt = "Os saurópodes (do latim científico Sauropoda) foram um dos dois grandes grupos de dinossauros saurísquios ou dinossauros com bacia de réptil. Os seus corpos eram enormes, com um pescoço muito comprido que terminava em uma cabeça muito pequena. A cauda, também muito comprida, junto com uma grande unha que a maioria dos saurópodes possuíam na pata dianteira, eram suas únicas armas de defesa, além de seu tamanho.";
        addFamilia(sprites[0], "Saurópodes", txt);
        addFamilia(sprites[1], "Carnosauria", txt);
        addFamilia(sprites[2], "Tyrannosauridae", txt);
        addFamilia(sprites[3], "Compsognatídeos", txt);
        addFamilia(sprites[4], "Therizinossauro", txt);
        addFamilia(sprites[5], "Alvarezsaurídeos", txt);
        addFamilia(sprites[6], "Oviraptorosauria", txt);
        addFamilia(sprites[7], "Oviraptorosauria", txt);
        addFamilia(sprites[8], "Tradentids", txt);
        addFamilia(sprites[9], "Dromzeosaurs", txt);
        addFamilia(sprites[10], "Dromzeosaurs", txt);
        addFamilia(sprites[11], "Sacnoriopterygids", txt);
        addFamilia(sprites[12], "Aves", txt);
        addFamilia(sprites[13], "Aves", txt);
        addFamilia(sprites[14], "Aves", txt);
        addFamilia(sprites[15], "Aves Modernas", txt);
    }
    public void addFamilia(Sprite spr, string titulo, string texto) {
        familiasDinossauro.Add(new FamiliaDinossauro(spr,titulo,texto));
    }
    public FamiliaDinossauro get(int index) {
        return familiasDinossauro[index];
    }
}
