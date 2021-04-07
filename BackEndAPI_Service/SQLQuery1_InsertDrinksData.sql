SET IDENTITY_INSERT dbo.Drinks on;

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(1,'Bushmill', 90, 700, 99.00, 'https://hospitalityreviewni.com/wp-content/uploads/2017/02/160117BT2-11-1024x683.jpg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(2,'Cheeky Vimto', 70, 900, 100.00, 'https://www.socialandcocktail.co.uk/wp-content/uploads/2011/12/Cheeky-Vimto.jpg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(3,'LAVA', 20, 500, 200.00, 'https://stressbaking.com/wp-content/uploads/2020/05/lava-flow-1-4.jpg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(4,'Kelvin Slush', 30, 300, 125.00, 'https://cdn.business2community.com/wp-content/uploads/2017/01/KelvinSlush.jpg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(5,'Passion fruit martini', 60, 700, 110.95, 'https://images.immediate.co.uk/production/volatile/sites/30/2020/08/passionfruit-pornstar-martini-df3bbfb.jpg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(6,'Piña colada', 35, 600, 12.21, 'https://www.dominosugar.com/emshare/views/modules/asset/downloads/originals/2020/06/72589/Pina_Colada_600x400.jpg/Pina_Colada_600x400.jpg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(7,'Frozen strawberry daiquiri', 90, 900, 90.95, 'https://www.thespruceeats.com/thmb/Wkv4Vu76pPHtdgJ52Jn7ffcikL0=/2048x1152/smart/filters:no_upscale()/strawberry-daiquiri-recipes-759821_13_preview1-5b05f448ba61770036fbae90.jpeg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(8,'Rum punch', 10, 100, 85.76, 'https://images.immediate.co.uk/production/volatile/sites/30/2020/08/rum-punch-5c8fd79.jpg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(9,'Cosmopolitan', 20, 200, 400.92, 'https://images.immediate.co.uk/production/volatile/sites/30/2020/08/cosmopolitan-7a6874f.jpg?quality=90&webp=true&resize=440,400');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(10,'Mikes Hard Lemonade Seltzer', 90, 900, 1.99, 'https://vinepair.com/wp-content/uploads/2020/01/trulymikeshard_social-1280x720.jpg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(11,'Cutwater White Russian', 9000, 100, 2.99, 'https://www.spiritedbiz.com/wp-content/uploads/2020/12/GCC_2011_ON_White_DSC09398.jpg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(12,'Onda Sparkling Tequila', 100, 700, 3.99, 'https://media1.popsugar-assets.com/files/thumbor/NrnZv8zIgs7vy6JDKiPcUPVWDQg/fit-in/2048xorig/filters:format_auto-!!-:strip_icc-!!-/2020/07/15/784/n/1922195/tmp_57AZKQ_9c563dd5ae61bb61_Onda_Ad_Feed_Beach_1080x1080.jpg');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(13,'Espresso Martini', 86, 850, 45.50, 'https://images.absolutdrinks.com/drink-images/Raw/Absolut/2bc2bb4c-17d6-4a3c-9df2-4d22f8553d24.jpg?imwidth=500');

INSERT INTO dbo.Drinks(ID, DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES(14,'Cocktail Squad Whiskey Sour', 23, 700, 67.78, 'https://www.barbizmag.com/wp-content/uploads/2020/08/cocktailsquadwhiskeysour-300x216.jpg');

SET IDENTITY_INSERT dbo.Drinks off;








delete from dbo.Drinks;

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Bushmill', 90, 700, 99.00, 'https://hospitalityreviewni.com/wp-content/uploads/2017/02/160117BT2-11-1024x683.jpg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Cheeky Vimto', 70, 900, 100.00, 'https://www.socialandcocktail.co.uk/wp-content/uploads/2011/12/Cheeky-Vimto.jpg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('LAVA', 20, 500, 200.00, 'https://stressbaking.com/wp-content/uploads/2020/05/lava-flow-1-4.jpg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Kelvin Slush', 30, 300, 125.00, 'https://cdn.business2community.com/wp-content/uploads/2017/01/KelvinSlush.jpg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Passion fruit martini', 60, 700, 110.95, 'https://images.immediate.co.uk/production/volatile/sites/30/2020/08/passionfruit-pornstar-martini-df3bbfb.jpg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Piña colada', 35, 600, 12.21, 'https://www.dominosugar.com/emshare/views/modules/asset/downloads/originals/2020/06/72589/Pina_Colada_600x400.jpg/Pina_Colada_600x400.jpg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Frozen strawberry daiquiri', 90, 900, 90.95, 'https://www.thespruceeats.com/thmb/Wkv4Vu76pPHtdgJ52Jn7ffcikL0=/2048x1152/smart/filters:no_upscale()/strawberry-daiquiri-recipes-759821_13_preview1-5b05f448ba61770036fbae90.jpeg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Rum punch', 10, 100, 85.76, 'https://images.immediate.co.uk/production/volatile/sites/30/2020/08/rum-punch-5c8fd79.jpg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Cosmopolitan', 20, 200, 400.92, 'https://images.immediate.co.uk/production/volatile/sites/30/2020/08/cosmopolitan-7a6874f.jpg?quality=90&webp=true&resize=440,400');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Mikes Hard Lemonade Seltzer', 90, 900, 1.99, 'https://vinepair.com/wp-content/uploads/2020/01/trulymikeshard_social-1280x720.jpg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Cutwater White Russian', 9000, 100, 2.99, 'https://www.spiritedbiz.com/wp-content/uploads/2020/12/GCC_2011_ON_White_DSC09398.jpg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Onda Sparkling Tequila', 100, 700, 3.99, 'https://media1.popsugar-assets.com/files/thumbor/NrnZv8zIgs7vy6JDKiPcUPVWDQg/fit-in/2048xorig/filters:format_auto-!!-:strip_icc-!!-/2020/07/15/784/n/1922195/tmp_57AZKQ_9c563dd5ae61bb61_Onda_Ad_Feed_Beach_1080x1080.jpg');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Espresso Martini', 86, 850, 45.50, 'https://images.absolutdrinks.com/drink-images/Raw/Absolut/2bc2bb4c-17d6-4a3c-9df2-4d22f8553d24.jpg?imwidth=500');

INSERT INTO dbo.Drinks(DrinkName, PercentageOfAlcohol, Milliliter, Price, ImageUrl) 
	VALUES('Cocktail Squad Whiskey Sour', 23, 700, 67.78, 'https://www.barbizmag.com/wp-content/uploads/2020/08/cocktailsquadwhiskeysour-300x216.jpg');
