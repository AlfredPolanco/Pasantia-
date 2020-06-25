from tika import parser 
raw = parser.from_file('Boletin-especial-96.pdf')
print(raw['content'])
#pip install tika


##pip install tabula-py
## este es el que da mucho NaN
import tabula
# readinf the PDF file that contain Table Data
# you can find find the pdf file with complete code in below
# read_pdf will save the pdf table into Pandas Dataframe
df = tabula.read_pdf("Boletin-especial-96.pdf")
# in order to print first 5 lines of Table
print(df)
