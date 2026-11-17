using PhotoSipSakHW;
//Flaş ile foto çekme telefon ve fotog.m. var
//ama tüm nesneler fotoğraf çekebiliyor.
//herkesin f.karesi sayısı:30
Battery sony = new Battery(1, "Sony");
Battery android = new Battery(2, "Android");
Battery duracell = new Battery(3, "Duracell");
PhotografMachine photografMachine = new PhotografMachine(1, "Sony", sony);
Phone phone = new Phone(1, "Samsung", android);
Drone drone = new Drone(1, "DroneTek", duracell);

photografMachine.TakePhotoWithFlash(25, "Galata Kulesi");
photografMachine.TakePhoto(5, "Topkapı Sarayı");
Console.WriteLine(photografMachine);

phone.TakePhotoWithFlash(21, "Kızılay");
phone.TakePhoto(11, "Anıtkabir");
Console.WriteLine(phone);

drone.TakePhoto(20, "Esenboğa Havalimanı");
Console.WriteLine(drone );
