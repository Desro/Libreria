using System;
using Libreria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAgregarCategoriaObjeto()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            Categoria cat = new Categoria();
            cat.Idcategoria = 1;
            cat.Nombre = "Balsamo";
            cat.Descripcion = "Las 3 B";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //act
            resultadoObtenido = auxCat.Agregar(cat);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestAgregarCategoriaParamaetros()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();

            var idCategoria = 2;
            var nombre = "Acondicionador";
            var descripcion = "Malardo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //act
            resultadoObtenido = auxCat.Agregar(idCategoria, nombre, descripcion);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestAgregarCategoriaSNombre()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            Categoria cat = new Categoria();
            cat.Idcategoria = 3;
            cat.Descripcion = "Las 3 B";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //act
            resultadoObtenido = auxCat.Agregar(cat);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestAgregarCategoriaSDescricion()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            Categoria cat = new Categoria();
            cat.Idcategoria = 1;
            cat.Nombre = "Balsamo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //act
            resultadoObtenido = auxCat.Agregar(cat);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestAgregarCategoriaSID()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            Categoria cat = new Categoria();
            cat.Nombre = "Balsamo";
            cat.Descripcion = "Las 3 B";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //act
            resultadoObtenido = auxCat.Agregar(cat);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestModificarObjeto()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            Categoria cat = new Categoria();
            cat.Idcategoria = 5;
            cat.Nombre = "Jabon";
            cat.Descripcion = "Las 2 B";

            auxCat.Agregar(cat);

            cat.Idcategoria = 5;
            cat.Nombre = "Jabonsito";
            cat.Descripcion = "Las 4 B";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //act
            resultadoObtenido = auxCat.Modificar(cat);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestModificarParametros()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            Categoria cat = new Categoria();

            cat.Idcategoria = 1;
            cat.Nombre = "Shampoo";
            cat.Descripcion = "1 B";

            var Idcategoria = 1;
            var Nombre = "Jabon";
            var Descripcion = "Las 2 B";
            auxCat.Agregar(Idcategoria, Nombre, Descripcion);

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //act
            resultadoObtenido = auxCat.Modificar(Idcategoria, Nombre, Descripcion);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestModificarObjetoSNombre()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            Categoria cat = new Categoria();
            cat.Idcategoria = 5;
            cat.Nombre = "Shampoo";
            cat.Descripcion = "Las 2 B";

            auxCat.Agregar(cat);

            cat.Idcategoria = 5;
            cat.Descripcion = "Las 7 b";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //act
            resultadoObtenido = auxCat.Modificar(cat);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestModificarObjetoSDescripcion()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            Categoria cat = new Categoria();
            cat.Idcategoria = 5;
            cat.Nombre = "Jabon";
            cat.Descripcion = "Buen Jabon";

            auxCat.Agregar(cat);

            cat.Idcategoria = 5;
            cat.Nombre = "Balsamo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //act
            resultadoObtenido = auxCat.Modificar(cat);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestModificarObjetoSID()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            Categoria cat = new Categoria();
            cat.Idcategoria = 5;
            cat.Nombre = "Jabon";
            cat.Descripcion = "Las 2 B";

            auxCat.Agregar(cat);

            cat.Nombre = "Shampoo";
            cat.Descripcion = "Malisimo";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //act
            resultadoObtenido = auxCat.Modificar(cat);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void eliminarIDexistente()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            int categoriaExistente = 1;
            Categoria cat = new Categoria();
            cat.Idcategoria = 1;
            cat.Nombre = "shampoo";
            cat.Descripcion = "genial";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;
            auxCat.Agregar(cat);

            //act
            resultadoObtenido = auxCat.Eliminar(categoriaExistente);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void eliminarIDnoExistente()
        {
            //arrange
            AuxCategoria auxCat = new AuxCategoria();
            Categoria cat = new Categoria();
            cat.Idcategoria = 1;
            cat.Nombre = "shampoo";
            cat.Descripcion = "genial";
            auxCat.Agregar(cat);

            int resultadoEsperado = 0;
            int resultadoObtenido = 0;
            auxCat.Agregar(cat);

            //act
            resultadoObtenido = auxCat.Eliminar(2);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void generarInstanciaSParametros()
        {
            //arrange
            Categoria categoria;
            //act
            categoria = new Categoria();
            //assert
            Assert.IsNotNull(categoria);

        }

        [TestMethod]
        public void generarInstanciaConParametros()
        {
            //arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Acondicionador";
            string descripcion = "4 B, muy weno";
            //act
            categoria = new Categoria(idCategoria, nombre, descripcion);
            //assert
            Assert.IsNotNull(categoria);

        }


        [TestMethod]
        public void obtenerIdCategoria()
        {
            //arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Balsamo";
            string descripcion = "Re bueno";

            int resultadoEsperado = 10;
            int resultadoObtenido = 0;
            //act
            categoria = new Categoria(idCategoria, nombre, descripcion);

            resultadoObtenido = categoria.Idcategoria;
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void obtenerNombre()
        {
            //arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Balsamo";
            string descripcion = "Re bueno";

            string resultadoEsperado = "Balsamo";
            string resultadoObtenido = "";
            //act
            categoria = new Categoria(idCategoria, nombre, descripcion);

            resultadoObtenido = categoria.Nombre;
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void obtenerDescripcion()
        {
            //arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Balsamo";
            string descripcion = "Re bueno";

            string resultadoEsperado = "Re bueno";
            string resultadoObtenido = "";
            //act
            categoria = new Categoria(idCategoria, nombre, descripcion);

            resultadoObtenido = categoria.Descripcion;
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void DefinirIdCategoria()
        {
            //arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Balsamo";
            string descripcion = "Re bueno";

            int resultadoEsperado = 13;
            int resultadoObtenido = 0;
            //act
            categoria = new Categoria(idCategoria, nombre, descripcion);
            categoria.Idcategoria = 13;
            resultadoObtenido = categoria.Idcategoria;
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void DefinirNombre()
        {
            //arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Balsamo";
            string descripcion = "Re bueno";

            string resultadoEsperado = "Jabon";
            string resultadoObtenido = "";
            //act
            categoria = new Categoria(idCategoria, nombre, descripcion);
            categoria.Nombre = "Jabon";
            resultadoObtenido = categoria.Nombre;
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void DefinirDescripcion()
        {
            //arrange
            Categoria categoria;
            int idCategoria = 10;
            string nombre = "Balsamo";
            string descripcion = "Re bueno";

            string resultadoEsperado = "Malardo";
            string resultadoObtenido = "";
            //act
            categoria = new Categoria(idCategoria, nombre, descripcion);
            categoria.Descripcion = "Malardo";
            resultadoObtenido = categoria.Descripcion;
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }


        //TERMINAN LOS UNITARIOS

        [TestMethod]

        public void AgregarProductoCategoriaObjeto() //tambien se prueba el agregar categoria por objeto
        {
            AuxProducto auxPro = new AuxProducto();
            Producto prod = new Producto();
            AuxCategoria auxCate = new AuxCategoria();
            Categoria cate = new Categoria();

            cate.Idcategoria = 1;
            cate.Nombre = "Shampoo";
            cate.Descripcion = "Muy bueno";

            int resultadoEsperado1 = 1;
            int resultadoObtenido1 = 0;

            resultadoObtenido1 = auxCate.Agregar(cate);


            prod.IdProducto = 1;
            prod.Nombre = "Producto1";
            prod.Precio = 1000;
            prod.Stock = 5;
            prod.Cat = cate;
            prod.Estado = true;


            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            resultadoObtenido = auxPro.AgregarProducto(prod);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            Assert.AreEqual(resultadoEsperado1, resultadoObtenido1);

        }

        [TestMethod]
        public void AgregarProductoParametros() //no pude agregar cat por parametros, no sabia como llamarla dsps 
        {
            AuxProducto auxPro = new AuxProducto();
            Categoria cate = new Categoria();
            AuxCategoria auxCate = new AuxCategoria();

            int resultadoEsperado1 = 1;
            int resultadoObtenido1 = 0;



            cate.Idcategoria = 1;
            cate.Nombre = "Shampoo";
            cate.Descripcion = "Muye bueno";

            resultadoObtenido1 = auxCate.Agregar(cate);

            var idProducto = 1;
            var nombre = "Nose";
            var precio = 100;
            var stock = 5;
            var cat = cate;
            var estado = true;


            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            resultadoObtenido = auxPro.AgregarProducto(idProducto, nombre, estado, cat, precio, stock);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            Assert.AreEqual(resultadoEsperado1, resultadoObtenido1);
        }

        [TestMethod]
        public void DardeBajaProductoExistente()
        {
            //se agrega categoria y producto
            AuxProducto auxPro = new AuxProducto();
            Producto prod = new Producto();
            AuxCategoria auxCate = new AuxCategoria();
            Categoria cate = new Categoria();

            cate.Idcategoria = 1;
            cate.Nombre = "Shampoo";
            cate.Descripcion = "Muy bueno";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            auxCate.Agregar(cate);


            prod.IdProducto = 1;
            prod.Nombre = "Producto1";
            prod.Precio = 1000;
            prod.Stock = 5;
            prod.Cat = cate;
            prod.Estado = true;

            auxPro.AgregarProducto(prod);

            resultadoObtenido = auxPro.DardeBaja(1);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void DardeBajaProductoNoExistente()
        {
            //se agrega categoria y producto
            AuxProducto auxPro = new AuxProducto();
            Producto prod = new Producto();
            AuxCategoria auxCate = new AuxCategoria();
            Categoria cate = new Categoria();

            cate.Idcategoria = 1;
            cate.Nombre = "Shampoo";
            cate.Descripcion = "Muy bueno";

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            auxCate.Agregar(cate);


            prod.IdProducto = 1;
            prod.Nombre = "Producto1";
            prod.Precio = 1000;
            prod.Stock = 5;
            prod.Cat = cate;
            prod.Estado = true;

            auxPro.AgregarProducto(prod);

            resultadoObtenido = auxPro.DardeBaja(2);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }


        [TestMethod]
        public void TestActualizarStock()
        {
            AuxProducto auxPro = new AuxProducto();
            Producto prod = new Producto();
            AuxCategoria auxCate = new AuxCategoria();
            Categoria cate = new Categoria();

            cate.Idcategoria = 3;
            cate.Nombre = "Shampoooo";
            cate.Descripcion = "Muy buenardo";

            auxCate.Agregar(cate);

            prod.IdProducto = 1;
            prod.Nombre = "Producto1";
            prod.Precio = 1000;
            prod.Stock = 5;
            prod.Cat = cate;
            prod.Estado = true;

            auxPro.AgregarProducto(prod);

            int resultadoEsperado = 10;
            int resultadoObtenido = 0;

            var idProducto = 1;
            var cantidadAgregar = 5;

            //act
            resultadoObtenido = auxPro.ActualizarStock(idProducto, cantidadAgregar);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }


        [TestMethod]
        public void TestModificarProducto() //Solo tiene metodo por parametros
        {
            AuxProducto auxPro = new AuxProducto();
            Producto prod = new Producto();
            AuxCategoria auxCate = new AuxCategoria();
            Categoria cate = new Categoria();

            cate.Idcategoria = 3;
            cate.Nombre = "Shampoooo";
            cate.Descripcion = "Muy buenardo";

            auxCate.Agregar(cate);

            prod.IdProducto = 1;
            prod.Nombre = "Producto1";
            prod.Precio = 1000;
            prod.Stock = 5;
            prod.Cat = cate;
            prod.Estado = true;

            auxPro.AgregarProducto(prod);

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            var idProducto = 1;
            var nombre = "Producto33";
            var cat = cate;
            var precio = 200;
            var stock = 3;

            //act
            resultadoObtenido = auxPro.Modificar(idProducto, nombre, cat, precio, stock);

            //assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

    }
}
