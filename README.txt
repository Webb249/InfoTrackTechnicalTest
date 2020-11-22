No setup should be required just build the main project and run.

The file is split into two projects. One is the main code and the other a testing project.

The web application is a ASP.Net MVC project.

To use the program:
	Enter the search phrase
	Enter the URL
	Select the search engine to be used (Bing currently not working)
	Click "Find Position"
	View results

Most the code is inside the .cs files SearchEngineReader and SearchEngineResultSearcher. These files have corresponding test files in the test project.
A factory is implemented with the .cs files SearchEngine, SearchEngineType, SearchEngineGoogle and SearchEngineBing.

