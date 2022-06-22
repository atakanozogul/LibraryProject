-Öncelikle projeye tablo yapılarımı düşünerek başladım.

-İlk adım olarak olması gereken tablolar ve tablolarda bulunacak propertleri kağıda yazarak kafamda planımı yaptım.

-Kitapları listelemek için Kitap tablosu, alan kullanıcıları belirlemem ve eklemem için kullanıcı tablosu ve logları tutmak için log tablosuna karar verdim.

-Katmanlı mimari kullandığım için katmanlarımı oluşturdum, gereken paketleri yükledim ve EntityLayer katmanına entitylerimi ekledim.

-Entityleri ekledikten sonra Database ile bağlantıyı gerçekleştirmek için DbContext oluşturdum ve bu Contexti de Startup içerisinde belirttim. Bu sayede migration işlemlerim gerçekleşmiş oldu.

-Migration yaparak Database tarafında bir sorun olup olmadığını ve ilişkilerimin doğruluğunu kontrol ettim.

-Daha sonra Repositoryleri ekledim ve onların interface'lerini ekledim.

-BusinessLayer içerisine servislerimi ve interfacelerini oluşturdum.

-Validasyonları da BusinessLayer içerisine ekledim.

-UI tarafı için BookLibray katmanını kullandım ve burada ilk önce controllerlar ekleyip içerisindeki istediğim metodları düzenledim.

-Models klasörü içerisine viewModel ekledim çünkü istemediğim kısımları almayıp işimi kolaylaştırmak istedim.

-Views tarafında ilk önce Layout üzerinde ayarlamalarımı yaptım ve Navbar üzerinde kitaplar ve okuyucular bölümüne gitmesi için butonlar koydum.

-Book, Home ve Reader için viewlar oluşturdum ve istediğim ayarlamaları gerçekleştirdim.

-Son olarak test işlemlerimi gerçekleştirdim ve bazı hataların olduğunu farkettim. Hatalardan bazıları validasyonlarda yaşandı bazıları ise kitap ekleme kısmında iptal butonunun çalışmadığını ve yine de kitap eklediğini farkettim.

-Hataların çözümünü bulduktan sonra projeyi son haline getirmiş oldum.
