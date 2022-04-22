import shutil

with open('CLASSIFICATIONS.txt','wb') as wfd:
    for f in ['CLASSIFICATIONS_AO.txt','CLASSIFICATIONS_BO.txt','CLASSIFICATIONS_CO.txt',
              'CLASSIFICATIONS_DO.txt','CLASSIFICATIONS_EO.txt','CLASSIFICATIONS_FO.txt',
              'CLASSIFICATIONS_GO.txt','CLASSIFICATIONS_HO.txt','CLASSIFICATIONS_IO.txt',
              'CLASSIFICATIONS_JO.txt','CLASSIFICATIONS_KO.txt','CLASSIFICATIONS_LO.txt',
              'CLASSIFICATIONS_MO.txt','CLASSIFICATIONS_NO.txt','CLASSIFICATIONS_OO.txt',
              'CLASSIFICATIONS_PO.txt','CLASSIFICATIONS_QO.txt','CLASSIFICATIONS_RO.txt',
              'CLASSIFICATIONS_SO.txt','CLASSIFICATIONS_TO.txt','CLASSIFICATIONS_UO.txt',
              'CLASSIFICATIONS_VO.txt','CLASSIFICATIONS_XO.txt','CLASSIFICATIONS_YO.txt',
              'CLASSIFICATIONS_AM.txt','CLASSIFICATIONS_BM.txt','CLASSIFICATIONS_CM.txt',
              'CLASSIFICATIONS_DM.txt','CLASSIFICATIONS_EM.txt','CLASSIFICATIONS_FM.txt',
              'CLASSIFICATIONS_GM.txt','CLASSIFICATIONS_HM.txt','CLASSIFICATIONS_IM.txt',
              'CLASSIFICATIONS_JM.txt','CLASSIFICATIONS_KM.txt','CLASSIFICATIONS_LM.txt',
              'CLASSIFICATIONS_MM.txt','CLASSIFICATIONS_NM.txt','CLASSIFICATIONS_OM.txt',
              'CLASSIFICATIONS_PM.txt','CLASSIFICATIONS_QM.txt','CLASSIFICATIONS_RM.txt',
              'CLASSIFICATIONS_SM.txt','CLASSIFICATIONS_TM.txt','CLASSIFICATIONS_UM.txt',
              'CLASSIFICATIONS_VM.txt','CLASSIFICATIONS_XM.txt','CLASSIFICATIONS_YM.txt',
              'CLASSIFICATIONS_WO.txt','CLASSIFICATIONS_ZO.txt','CLASSIFICATIONS_1O.txt',
              'CLASSIFICATIONS_2O.txt','CLASSIFICATIONS_3O.txt','CLASSIFICATIONS_4O.txt',
              'CLASSIFICATIONS_5O.txt','CLASSIFICATIONS_6O.txt','CLASSIFICATIONS_7O.txt',
              'CLASSIFICATIONS_8O.txt','CLASSIFICATIONS_9O.txt','CLASSIFICATIONS_0O.txt',
              'CLASSIFICATIONS_ᜀO.txt','CLASSIFICATIONS_ᜊO.txt','CLASSIFICATIONS_ᜃO.txt',
              'CLASSIFICATIONS_ᜇO.txt','CLASSIFICATIONS_ᜁO.txt','CLASSIFICATIONS_ᜄO.txt',
              'CLASSIFICATIONS_ᜑO.txt', 'CLASSIFICATIONS_ᜎO.txt', 'CLASSIFICATIONS_ᜋO.txt',
              'CLASSIFICATIONS_ᜈO.txt','CLASSIFICATIONS_WM.txt','CLASSIFICATIONS_ZM.txt',
              'CLASSIFICATIONS_1M.txt','CLASSIFICATIONS_2M.txt','CLASSIFICATIONS_3M.txt',
              'CLASSIFICATIONS_4M.txt','CLASSIFICATIONS_5M.txt','CLASSIFICATIONS_6M.txt',
              'CLASSIFICATIONS_7M.txt','CLASSIFICATIONS_8M.txt','CLASSIFICATIONS_9M.txt',
              'CLASSIFICATIONS_0M.txt','CLASSIFICATIONS_ᜀM.txt','CLASSIFICATIONS_ᜊM.txt',
              'CLASSIFICATIONS_ᜃM.txt','CLASSIFICATIONS_ᜇM.txt','CLASSIFICATIONS_ᜁM.txt',
              'CLASSIFICATIONS_ᜄM.txt','CLASSIFICATIONS_ᜑM.txt','CLASSIFICATIONS_ᜎM.txt',
              'CLASSIFICATIONS_ᜋM.txt','CLASSIFICATIONS_ᜈM.txt']:
        with open(f,'rb') as fd:
            shutil.copyfileobj(fd, wfd)