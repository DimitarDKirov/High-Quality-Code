//var expect=require('chai').expect,
var chai=require('chai'),
expect=chai.expect,
assert=chai.assert;

describe('sampe test', function(){
	it('expect 5 to equal 5', function(){
		expect(5).to.be.equal(5);
		expect(6).to.be.a('number');
		function P(){}
		expect(new P()).to.be.an.instanceof(P);
		expect(6).not.to.be.equal(5);
	});
	it('more tests',function(){
		expect([]).to.have.length(0);
		expect([1,2,3]).to.contain(3);
		assert.equal(4/2,2);
		//expect([1,2,3,4]).not.to.contain(4);
		expect({name:'Mitko'}).to.have.key('name');
		expect({name:'Mitko'}).not.to.have.key('age');


	});
});