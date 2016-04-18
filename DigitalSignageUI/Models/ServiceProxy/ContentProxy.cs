using DigitalSignageUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DigitalSignageUI.ContentsServices;
using DigitalSignageUI.Models.Mapper;
using Aryaban.Engine.Core.WebService;

namespace DigitalSignageUI.Models.ServiceProxy
{
    public class ContentProxy
    {
        public ResultMessage<List<AdsInfo>> loadContentsWithAdsItemDetail(long content_id)
        {
            
            List<AdsInfo> listContentInfo = new List<AdsInfo>();
            using (IcontentsClient clientProxy = new IcontentsClient())
            {
                ResultMessage<AdsInfoWTO[]> serviceResult;

                serviceResult = clientProxy.loadContentsWithAdsItemDetail( content_id);
                switch (serviceResult.result.status)
                {
                    case Result.state.error:
                        return new ResultMessage<List<AdsInfo>>
                        {
                            resultSet = null,
                            result =
                                {
                                    status = Aryaban.Engine.Core.WebService.Result.state.error,
                                    message = serviceResult.result.message
                                }
                        };
                        break;
                    case Result.state.success:
                        listContentInfo = ContentMapper.MapFrom(serviceResult.resultSet);
                        return new ResultMessage<List<AdsInfo>>
                        {
                            resultSet = listContentInfo,
                            result = new Result()
                            {
                                    status = Aryaban.Engine.Core.WebService.Result.state.success,
                                }
                        };
                        break;
                    default:
                        return new ResultMessage<List<AdsInfo>>
                        {
                            resultSet = null,
                            result = new Result()
                            {
                                    status = Aryaban.Engine.Core.WebService.Result.state.warning,
                                }
                        };
                        break;
                }

            }

        }
    }
}