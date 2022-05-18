import numpy as np
import pandas as pd


def main():
    pd.set_option('display.max_columns', None)

    # dtype = {'tconst': 'string', 'titleType': 'string', 'primaryTitle': 'string', 'originalTitle': 'string',
    #          'isAdult': 'string', 'startYear': 'string', 'endYear': 'string', 'runtimeMinutes': 'string',
    #          'genre': 'string'}
    df = pd.read_csv('imdb/title.basics.tsv', sep='\t', low_memory=False)
    df.set_index('tconst', inplace=True)
    df.replace("\\N", np.nan, inplace=True)
    df['endYear'] = df.replace(" ", np.nan, inplace=True)

    selected_columns = ['titleType', 'primaryTitle', 'originalTitle']

    df = df[selected_columns]
    print(df)
    df.to_csv('imdb/title.basic.csv')


if __name__ == '__main__':
    main()
