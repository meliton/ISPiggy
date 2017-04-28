# ISPiggy
Decentralized DNS fuzzer to mitigate ISP Snooping

ISP's can track your DNS requests. <br>
The goal of this project is to disguise your web surfing habits from your ISP or DNS provider by injecting random DNS domain name  requests for the upstream DNS server to resolve.<br>

# What does this accomplish?

* Their DNS logs will have many erroneous DNS requests
* With enough fuzzy requests, they will have too much unreliable info to data mine

## Features
* Random domain name generation
* Start and Stop buttons
* Debug feature - allows user interactive domain name creation and submission
* Minimizes to the system tray
* Built on .NET 2.0 for maximum compatibility

## TO DO
* Resolve minor issues with slow response from some DNS servers
