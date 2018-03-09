run:
	mysql -u root -p escapade

build:
	mysql -u root -p < constructor.sql --comments
	mysql -u root -p < fill.sql --comments

clean:
	mysql -u root -p < clean.sql --comments

remake:
	clean
	build:

