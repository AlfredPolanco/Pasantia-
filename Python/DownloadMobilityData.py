import os
import requests

try:
    url= 'https://www.gstatic.com/covid19/mobility/Global_Mobility_Report.csv?cachebust=694ae9957380f150'
    response = requests.get(url)
    ##Please specify the route where the file will be downloaded
    with open(os.path.join("F:\\Pasantia", "Mobility.csv"), 'wb') as f:
        f.write(response.content)
    
    print('File has been downloaded successfully')
##Please specify the route where the file will be downloaded
except:
    print('An error ocurred while downloading the data from the url')

##pip install requests