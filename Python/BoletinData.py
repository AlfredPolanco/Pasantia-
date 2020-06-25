from tika import parser 
raw = parser.from_file('Boletin-especial-96.pdf')
print(raw['content'])

#pip install tika
