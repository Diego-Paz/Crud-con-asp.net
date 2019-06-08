As a first step we create the project of the next manner
![image](https://user-images.githubusercontent.com/51175009/59139559-530d8380-8959-11e9-9e84-12b074b0a036.png)
![image](https://user-images.githubusercontent.com/51175009/59139571-6f112500-8959-11e9-944a-422fc2cbc95a.png)

Then select the next option MVC

![image](https://user-images.githubusercontent.com/51175009/59139587-923bd480-8959-11e9-96ce-8dfb8e25428d.png)

Now we wait just a moment until it create the project, continues create the database we will have to go to the tab to see and select the option object explorer of sql server, we arrived at this tab:

![image](https://user-images.githubusercontent.com/51175009/59139674-31f96280-895a-11e9-9403-44bf2fae1f7e.png)

in the tab do right click in data connections and select add connections this will open us a new tab where we select  archive of database of Microsoft SQL server we give you continue and for finish we name the database

![image](https://user-images.githubusercontent.com/51175009/59139690-57866c00-895a-11e9-9a80-51b707bed38b.png)
![image](https://user-images.githubusercontent.com/51175009/59139715-8e5c8200-895a-11e9-8167-e979311cda9e.png)
![image](https://user-images.githubusercontent.com/51175009/59139754-ccf23c80-895a-11e9-857b-5384a50882b7.png)

Already created the database now this will appear in data connections then open this and do right click in tables select add new table

![image](https://user-images.githubusercontent.com/51175009/59139800-50139280-895b-11e9-8ae7-718d81801cfb.png)

Will open the next graphic environment where name is the name that will have the columns of the table in our database will always put a default column named id which will be primary key, with that in mind we create the columns that our table, remembering what type of data is each because it is important for next steps.

![image](https://user-images.githubusercontent.com/51175009/59139811-73d6d880-895b-11e9-972f-ea6aedc4f180.png)

Now the primary key we activate the identity in the part lower right for that there is no conflict when we add new data

![image](https://user-images.githubusercontent.com/51175009/59139843-cb754400-895b-11e9-9597-3724cf327f7c.png)

For finalize we click on the update button we will get the following and press update database

![image](https://user-images.githubusercontent.com/51175009/59139864-f069b700-895b-11e9-80da-1c5614120d84.png)

Now we will create a new table called book which will have a foreign key as we will first perform the previous steps until before pressing the update button would be as follows

![image](https://user-images.githubusercontent.com/51175009/59140099-1c3a6c00-895f-11e9-9d4b-0689e5267114.png)

Now we right click on the external keys and select add a new external key to give us the format of the foreign key

![image](https://user-images.githubusercontent.com/51175009/59140153-ab478400-895f-11e9-9693-12b45c349be5.png)
![image](https://user-images.githubusercontent.com/51175009/59140160-c31f0800-895f-11e9-99f7-4dda89f473d8.png)

Now, in the error that you give us in the column, we replace this with the name of the column that will be a foreign key, then we return the ToTable and ToTableColumn errors by the name of the table and the column to which it will be reference respectively, and finalize we want to update

![image](https://user-images.githubusercontent.com/51175009/59140292-35dcb300-8961-11e9-9716-fdce41381141.png)

the next step is to create two folders in the models folder called DataAcces and DataModel, this is done by right clicking on the models folder we are going to add and inside we give you to add folder it would be this way

![image](https://user-images.githubusercontent.com/51175009/59140421-89033580-8962-11e9-88f7-2db62cca71a8.png)
![image](https://user-images.githubusercontent.com/51175009/59140435-b354f300-8962-11e9-9340-b9bdd21c0401.png)


now we import the database to DataModel by right clicking on this folder and we give it to add followed by class

![image](https://user-images.githubusercontent.com/51175009/59140458-3a09d000-8963-11e9-8df6-0f69e8b002df.png)

already in the interface we select the class ADO.NET Entity Data Model and we select add

![image](https://user-images.githubusercontent.com/51175009/59140486-b7cddb80-8963-11e9-98f6-df11a948493e.png)

then we select EF Designer from database we give it next and then again next time the database would be imported

![image](https://user-images.githubusercontent.com/51175009/59140539-a6d19a00-8964-11e9-9cef-171dffd78eb7.png)
![image](https://user-images.githubusercontent.com/51175009/59140540-b4871f80-8964-11e9-915f-081bf897c261.png)
![image](https://user-images.githubusercontent.com/51175009/59140541-d41e4800-8964-11e9-85fa-e6f96aab4943.png)


now we will create a class in models called BooksModel in which will be the data and actions that our program will have

![image](https://user-images.githubusercontent.com/51175009/59140610-c1f0d980-8965-11e9-96e1-9ad226dab490.png)
![image](https://user-images.githubusercontent.com/51175009/59140618-ee0c5a80-8965-11e9-8612-c4e04263f424.png)


we enter the model that we have just created and add the fields that our program will have by first writing public followed by the type of data that it will have and to finish the name of the field followed by opening keys in which internally the GET and SET methods will have which ended with a semicolon.

![image](https://user-images.githubusercontent.com/51175009/59140968-a3d9a800-896a-11e9-8b30-58dbccfa954d.png)

Now we will create a new class in DataAccess called booksdao and inside it we must import the DataModel with the "using"

![image](https://user-images.githubusercontent.com/51175009/59141131-34b18300-896d-11e9-97cb-0fd66cef8215.png)
![image](https://user-images.githubusercontent.com/51175009/59141143-63c7f480-896d-11e9-92b3-692a6a0e3e97.png)

with the DataModel already imported now we will create the action because we have connection with the database acontinuacion ponder the codes:

 //to create a record
 
        public void Create(BookModel u)
        
        {
        
          using (var data = new BooksEntities())
        
            {
                book bok = new book();
                
                bok.Name = u.Name;
                
                bok.author = u.author;
                
                bok.editorial = u.editorial;
                
                bok.edition = u.edition;
                
                bok.publication = u.publication;
                
                bok.id_city = u.id_city;
                
                bok.Country = u.Country;
                
                data.book.Add(bok);
                
                data.SaveChanges();
            }
        }
        
        //to delete a record
        public void Delete(decimal id)
        {
            using (var data = new BooksEntities())
            {
                var my = (from e in data.book select e).Where(z => z.Id.Equals(id)).FirstOrDefault();
                data.book.Remove(my);
                data.SaveChanges();
            }
        }
        //to find the record that we want to update
        public BookModel Consultbo(decimal Id)
        {
            BookModel re = new BookModel();
            using (var data = new BooksEntities())
            {
                var my = (from c in data.book select c).Where(z => z.Id.Equals(Id)).FirstOrDefault();
                re.id = my.Id;
                re.Name = my.Name;
                re.author = my.author;
                re.editorial = my.editorial;
                re.edition = my.edition;
                re.publication = my.publication;
                re.id_city = my.id_city;
                re.Country = my.Country;
            }
            return re;
        }
        //to update a record
        public void update(BookModel a)
        {
            using (var data = new BooksEntities())
            {
                var my = (from d in data.book where d.Id == a.id select d).FirstOrDefault();
                my.Name = a.Name;
                my.author = a.author;
                my.editorial = a.editorial;
                my.edition = a.edition;
                my.publication = a.publication;
                my.id_city = a.id_city;
                my.Country = a.Country;

                data.SaveChanges();
            }
        }
        //to see all the records
        public List<BookModel> Consult()
        {
            List<BookModel> result = new List<BookModel>();

            using (var data = new BooksEntities())
            {
                var resultconsult = (from d in data.book select d).ToList();
                foreach (var item in resultconsult)
                {
                    BookModel x = new BookModel();
                    x.id = item.Id;
                    x.Name = item.Name;
                    x.author = item.author;
                    x.editorial = item.editorial;
                    x.edition = item.edition;
                    x.publication = item.publication;
                    x.id_city = item.id_city;
                    x.Country = item.Country;

                    result.Add(x);
                }
            }
            return result;
        }














