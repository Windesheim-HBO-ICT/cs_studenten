### MAUI Navigation

The application shows a list of people, by selecting a person in the list you navigate to a page with the details of the selected person.

This sample shows one form of navigation in MAUI (there are more) and how to pass data as an object from one Page to another (the object has multiple properties).
Two implementations are available (one to use at a time), one uses the IQueryAttributable interface to retrieve the passed in data, 
	the other uses the [QueryProperty] attribute to retrieve the passed in data.
By changing the classnames of the viewmodels, each implementation can be used.





### Implementation 1 [QueryProperty]: 

This viewmodel has the [QueryProperty] attribute applied.
When navigating, the applications routing mechanism sets the PersonProperty with the value retrieved from the query by the PersonParameter key.
The data from the Person route query parameter is set by the applications routing mechanism to the PersonProperty which sets the data bindable properties to update the UI.

The view is depending on a ViewModel with name PersonDetailsViewModel
To use this class implementation:
 - make sure the classname in this file PersonDetailsViewModel_QP.cs is PersonDetailsViewModel
 - make sure the classname in file PersonDetailsViewModel_IQA.cs is PersonDetailsViewModel_IQA




### Implementation 2: IQueryAttributable

This viewmodel has the IQueryAttributable interface implemented.
When navigating, the method IQueryAttributable.ApplyQueryAttributes method is called by the applications routing mechanism.
The data from the Person route query parameter is set to data bindable properties to update the UI.

The view is depending on a ViewModel with name PersonDetailsViewModel
To use this implementation:
 - make sure the classname in file PersonDetailsViewModel_QP.cs is PersonDetailsViewModel_QP
 - make sure the classname in this file PersonDetailsViewModel_IQA.cs is PersonDetailsViewModel
