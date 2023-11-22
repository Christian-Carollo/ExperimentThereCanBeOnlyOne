List<int> listaInteri = new() {2, 5};

listaInteri.FirstOrDefault().ToString().ToList().ForEach(x => Console.WriteLine(x));

/*
 FirstOrDefault : Restituisce il primo elemento di una sequenza 
                  o un valore predefinito quando la sequenza è vuota (ovvero 0)
 */


List<int> listaInteri2 = new() {1, 6};


try
{
    listaInteri2.SingleOrDefault().ToString().ToList().ForEach(x => Console.WriteLine(x));
}
catch(InvalidOperationException)
{
    Console.WriteLine("Hai sollevato un Eccezione. La sequenza contiene più di un elemento");
}
/*
 SingleOrDefault: Restituisce l'unico elemento di una sequenza 
                  o un valore predefinito quando la sequenza è vuota (ovvero 0).
                  Solleva un eccezione se la sequenza contiene più di un elemento.
 */

/*QUINDI
 
 Se si desidera un solo elemento e si vuole essere certi che sia l'unico elemento con quel valore,
 quale si usa?

 SingleOrDefault.
 */
