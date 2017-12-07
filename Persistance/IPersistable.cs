using System.Collections.Generic;

namespace Persistance {

    // What does Persistable mean? It describes behaviour, saying that by attaching this interface to 
    // some object, you are making it Persistable. What Persistable means is then up to implementation
    // to decide, but you're describing the abstract idea by interface. 
    //
    // In this case, to make something become Persistable, you need to ensure that it has Data to persist
    // and a mechanism with which to persist said data, so Data and Save are born.
    //
    // TEntity is placeholder for any type that you want to instanciate this interface with.
    // For an example of this, go to SchoolPersistance.cs and look at the class declaration
    public interface IPersistable<TEntity> {
        TEntity Data { get; set; }
        int Save();
    }
}
