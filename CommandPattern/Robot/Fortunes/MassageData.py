import json

with open('Fortune.json', 'a') as writeToThisFile:
    with open('Raw Fortunes/data (16).json') as json_data:
        data = json.load(json_data)
        for element in data:
            line = "{\n\"Fortune\": " + element['Fortune'] + "\n},\n"
            writeToThisFile.write(line)
