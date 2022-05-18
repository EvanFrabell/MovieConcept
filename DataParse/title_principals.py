import numpy as np
import pandas as pd


def main():
    pd.set_option('display.max_columns', None)

    # dtype = {'tconst': 'string', 'titleType': 'string', 'primaryTitle': 'string', 'originalTitle': 'string',
    #          'isAdult': 'string', 'startYear': 'string', 'endYear': 'string', 'runtimeMinutes': 'string',
    #          'genre': 'string'}
    df = pd.read_csv('imdb/title.principals.tsv', sep='\t', low_memory=False)
    df.set_index('tconst', inplace=True)
    df.replace("\\N", np.nan, inplace=True)
    df.replace(" ", np.nan, inplace=True)

    # df['ordering'].astype(int)

    selected_columns = ['ordering', 'nconst', 'category']

    df = df.astype({'ordering': int, 'nconst': str, 'category': str})
    print(df.dtypes)

    df = df[selected_columns]
    print(df)
    df.to_csv('imdb/title.principals.csv')


if __name__ == '__main__':
    main()
