import { YMaps, Map } from '@pbe/react-yandex-maps';

function Test() {
  return (
    <YMaps>
    <div>
      My awesome application with maps!
      <Map defaultState={{ center: [36.625175422691406, 29.132220868637123], zoom: 14 }}  />
    </div>
  </YMaps>
  )
}

export default Test;
