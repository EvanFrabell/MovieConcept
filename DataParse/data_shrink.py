import numpy as np
import pandas as pd


def main():
    pd.set_option('display.max_columns', None)

    # df = pd.read_csv('imdb/title.basics.tsv', sep='\t', low_memory=False)
    # df.set_index('tconst', inplace=True)
    # # df.replace("\\N", np.nan, inplace=True)
    # df.replace("\\N", 'null', inplace=True)
    # df.replace(" ", 'null', inplace=True)
    #
    # df['startYear'].replace('null', 0, inplace=True)
    # df['startYear'] = df['startYear'].astype(int)
    #
    # df = df.loc[(df['titleType'] == 'movie') & (df['startYear'] > 2016)]
    #
    # df['runtimeMinutes'].replace('null', 0, inplace=True)
    # df['runtimeMinutes'] = df['runtimeMinutes'].astype(int)
    #
    # selected_columns = ['titleType', 'primaryTitle', 'originalTitle', 'startYear', 'runtimeMinutes', 'genres']
    # df = df[selected_columns]

    # print(df.dtypes)
    # print(df)
    #
    # df.to_csv('imdb/output/title.basics.csv')

    #### MATCH UP PRINCIPALS ####
    # df = pd.read_csv('imdb/output/title.basics.csv', low_memory=False)
    #     # df_prpl = pd.read_csv('imdb/title.principals.tsv', sep='\t', low_memory=False)
    #     # df_prpl.set_index('tconst', inplace=True)
    #     #
    #     # df_prpl = pd.merge(df_prpl, df, on='tconst')
    #     #
    #     # df_prpl['ordering'] = df_prpl['ordering'].astype(int)
    #     #
    #     # selected_columns = ['tconst', 'ordering', 'nconst', 'category']
    #     # df_prpl = df_prpl[selected_columns]
    #     #
    #     # df_prpl.set_index('tconst', inplace=True)
    #     #
    #     # print(df_prpl)
    #     #
    #     # df_prpl.to_csv('imdb/output/title.principals.csv')

    ### GET ONLY WHAT IS NEEDED IN name.basic table ####

    # df3 = pd.read_csv('imdb/output/title.principals.csv', low_memory=False)
    # df4 = pd.read_csv('imdb/name.basic.tsv', sep='\t', low_memory=False)
    #
    # df3.set_index('tconst', inplace=True)
    # df4.set_index('nconst', inplace=True)
    #
    # df4 = pd.merge(df4, df3, on='nconst')
    #
    # df4['birthYear'].replace('\\N', 0, inplace=True)
    # df4['birthYear'] = df4['birthYear'].astype(int)
    # df4['deathYear'].replace('\\N', 0, inplace=True)
    # df4['deathYear'] = df4['deathYear'].astype(int)
    #
    # selected_columns = ['nconst', 'primaryName', 'birthYear', 'deathYear', 'primaryProfession']
    # df4 = df4[selected_columns]
    #
    # df4.drop_duplicates(subset=['nconst'], inplace=True)
    #
    # df4.set_index('nconst', inplace=True)
    #
    # print(df4)
    #
    # df4.to_csv('imdb/output/name.basics.csv')

    #### title.crew gets broken up into separate columns for later SQL join - Get Directors/writers#####

    # df5 = pd.read_csv('imdb/output/title.basics.csv', index_col='tconst', low_memory=False)
    # df6 = pd.read_csv('imdb/title.crew.tsv', sep='\t', index_col='tconst', low_memory=False)
    # df9 = pd.read_csv('imdb/output/name.basics.csv', index_col='nconst', usecols=['nconst', 'primaryName'],
    #                   low_memory=False)
    #
    # df7 = pd.merge(df5, df6, on='tconst')
    #
    # selected_columns = ['directors', 'writers']
    # df7 = df7[selected_columns]
    #
    # # Probably a better way to do this, but this is a non-transferable concept
    # df8 = pd.DataFrame(df7['directors'].str.split(',').fillna('[]').to_list(), index=df7.index)
    # df8 = df8.reset_index().merge(df9, how='left', left_on=0, right_on='nconst').set_index('tconst')
    # df8 = df8.reset_index().merge(df9, how='left', left_on=1, right_on='nconst').set_index('tconst')
    # df8 = df8.reset_index().merge(df9, how='left', left_on=2, right_on='nconst').set_index('tconst')
    # selected_columns = ['primaryName_x', 'primaryName_y', 'primaryName']
    # df8 = df8[selected_columns]
    # df8.rename(columns={'primaryName_x': 'director1', 'primaryName_y': 'director2', 'primaryName': 'director3'},
    #            inplace=True)
    #
    # df10 = pd.DataFrame(df7['writers'].str.split(',').fillna('[]').to_list(), index=df7.index)
    # df10 = df10.reset_index().merge(df9, how='left', left_on=0, right_on='nconst').set_index('tconst')
    # df10 = df10.reset_index().merge(df9, how='left', left_on=1, right_on='nconst').set_index('tconst')
    # df10 = df10.reset_index().merge(df9, how='left', left_on=2, right_on='nconst').set_index('tconst')
    # selected_columns = ['primaryName_x', 'primaryName_y', 'primaryName']
    # df10 = df10[selected_columns]
    # df10.rename(columns={'primaryName_x': 'writer1', 'primaryName_y': 'writer2', 'primaryName': 'writer3'},
    #             inplace=True)
    #
    # df11 = pd.merge(df8, df10, on='tconst')
    # print(df11)
    # df11.to_csv('imdb/output/title.crew.csv')

    ###### title.rankings #######

    # dfb = pd.read_csv('imdb/output/title.basics.csv', index_col='tconst', low_memory=False)
    # dfr = pd.read_csv('imdb/title.ratings.tsv', sep='\t', index_col='tconst', low_memory=False)
    #
    # dfr = pd.merge(dfr, dfb, on='tconst')
    #
    # selected_columns = ['averageRating', 'numVotes']
    # dfr = dfr[selected_columns]
    #
    # print(dfr)
    # dfr.to_csv('imdb/output/title.ratings.csv')

    ###### title.akas #######

    # dfb = pd.read_csv('imdb/output/title.basics.csv', index_col='tconst', low_memory=False)
    # dfa = pd.read_csv('imdb/title.akas.tsv', sep='\t', index_col='titleId', low_memory=False)
    #
    # dfa = dfa.reset_index().merge(dfb, how='right', left_on='titleId', right_on='tconst').set_index('titleId')
    #
    # selected_columns = ['ordering', 'title', 'region']
    # dfa = dfa[selected_columns]
    # dfa.replace("\\N", 'null', inplace=True)
    # dfa.replace(" ", 'null', inplace=True)
    #
    # dfa['ordering'].replace('null', 0, inplace=True)
    # dfa['ordering'] = dfa['ordering'].astype('Int64')
    #
    # print(dfa)
    # dfa.to_csv('imdb/output/title.akas.csv')


    ### I messed up on name.basics ########
    dfx = pd.read_csv('imdb/name.basic.tsv', sep='\t', low_memory=False)
    dfx.set_index('nconst', inplace=True)

    selected_columns = ['primaryName', 'birthYear', 'deathYear', 'primaryProfession']
    dfx = dfx[selected_columns]

    dfx['birthYear'].replace('\\N', 0, inplace=True)
    dfx['birthYear'] = dfx['birthYear'].astype(int)
    dfx['deathYear'].replace('\\N', 0, inplace=True)
    dfx['deathYear'] = dfx['deathYear'].astype(int)

    print(dfx)

    dfx.to_csv('imdb/output/name.basics.csv')




if __name__ == '__main__':
    main()
