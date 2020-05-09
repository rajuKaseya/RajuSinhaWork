# RajuSinhaWork.
This Solution solves a problem where user passes any numerice number and gets back the same in word format e.g: input->203, output -> Two Hundred and Three.
The Solution contains three projects: 1.Library-> It implements core feature and provide the feature through an Interfaced based Convert method.
                                      2.Test Project->It contains Unit test for the method provided by Libray.
                                      3.WpfClient-> It is a Libary test project developed in WPF. It provides a user containg onext text box and two button
                                      .Text box contains the numeric number. One button is used to genrate an integer number and fill the text box using generated number.
                                      Second button once clicked, does the actual jon by calling the library provided Convert method. The result is displayed in the MessageBox
                                   
                    Note : The Library is based on interface based. The client calls teh method as loosely coupled. The client gets the reference throug
                           a factory method. 
                           
                           
                                      
